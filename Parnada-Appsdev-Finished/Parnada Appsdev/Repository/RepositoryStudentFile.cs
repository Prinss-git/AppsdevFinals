using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models;

namespace Parnada_Appsdev.Repository
{
    public class RepositoryStudentFile
    {
        public RepositoryResult CreateStudent(StudentFile modelStudent)
        {
            var result = new RepositoryResult();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                INSERT INTO StudentsRecord 
                (STFSTUDID, STFSTUDLNAME, STFSTUDFNAME, STFSTUDMNAME, STFSTUDCOURSE, STFSTUDYEAR, STFSTUDREMARKS, STFSTUDSTATUS) 
                VALUES (@STFSTUDID, @STFSTUDLNAME, @STFSTUDFNAME, @STFSTUDMNAME, @STFSTUDCOURSE, @STFSTUDYEAR, @STFSTUDREMARKS, @STFSTUDSTATUS);",
                            connection))
                {
                    // Dictionary for parameters
                    var parameters = new Dictionary<string, object>
                    {
                        { "@STFSTUDID", modelStudent.STFSTUDID },
                        { "@STFSTUDLNAME", modelStudent.STFSTUDLNAME },
                        { "@STFSTUDFNAME", modelStudent.STFSTUDFNAME },
                        { "@STFSTUDMNAME", modelStudent.STFSTUDMNAME },
                        { "@STFSTUDCOURSE", modelStudent.STFSTUDCOURSE },
                        { "@STFSTUDYEAR", modelStudent.STFSTUDYEAR },
                        { "@STFSTUDREMARKS", modelStudent.STFSTUDREMARKS },
                        { "@STFSTUDSTATUS", modelStudent.STFSTUDSTATUS }
                    };

                    // Add parameters dynamically
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(param.Key, param.Value ?? DBNull.Value));
                    }

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Returns affected rows
                    result.Success = rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Exception: {ex.Message}");
                result.Success = false;
                result.ErrorMessage = $"SQL Exception: {ex.Message}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                result.Success = false;
                result.ErrorMessage = $"Exception: {ex.Message}";
            }
            return result;
        }

        public int UpdateStudent(StudentFile student)
        {
            string query = @"
                UPDATE StudentsRecord 
                SET STFSTUDLNAME = @STFSTUDLNAME, STFSTUDFNAME = @STFSTUDFNAME, STFSTUDMNAME = @STFSTUDMNAME, 
                    STFSTUDCOURSE = @STFSTUDCOURSE, STFSTUDYEAR = @STFSTUDYEAR, 
                    STFSTUDREMARKS = @STFSTUDREMARKS, STFSTUDSTATUS = @STFSTUDSTATUS
                WHERE STFSTUDID = @STFSTUDID";

            try
            {
                using (var conn = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var cmd = new SqlCommand(query, conn))
                {
                    // Dictionary for parameters
                    var parameters = new Dictionary<string, object>
                    {
                        { "@STFSTUDID", student.STFSTUDID },
                        { "@STFSTUDLNAME", student.STFSTUDLNAME },
                        { "@STFSTUDFNAME", student.STFSTUDFNAME },
                        { "@STFSTUDMNAME", student.STFSTUDMNAME },
                        { "@STFSTUDCOURSE", student.STFSTUDCOURSE },
                        { "@STFSTUDYEAR", student.STFSTUDYEAR },
                        { "@STFSTUDREMARKS", student.STFSTUDREMARKS },
                        { "@STFSTUDSTATUS", student.STFSTUDSTATUS }
                    };

                    // Add parameters dynamically
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(new SqlParameter(param.Key, param.Value ?? DBNull.Value));
                    }

                    conn.Open();
                    return cmd.ExecuteNonQuery(); // Returns affected rows
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Exception: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return 0;
            }
        }

        public void DeleteStudent(long id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    connection.Open();
                    string sql = "DELETE FROM StudentsRecord WHERE STFSTUDID = @STFSTUDID;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@STFSTUDID", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL exception: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        // Get all students
        public DataTable GetStudents()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    connection.Open();
                    string sql = "SELECT * FROM StudentsRecord;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL exception: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return dt;
        }
    }
    public class RepositoryResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
