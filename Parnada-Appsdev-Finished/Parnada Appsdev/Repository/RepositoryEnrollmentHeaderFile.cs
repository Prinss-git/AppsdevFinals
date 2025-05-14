using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models;

namespace Parnada_Appsdev.Repository
{
    public class RepositoryEnrollmentHeaderFile
    {
        public List<EnrollmentHeaderFile> GetAllEnrollmentHeaders()
        {
            var enrollmentHeaders = new List<EnrollmentHeaderFile>();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                SELECT ENRHFSTUDID, ENRHFSTUDDATEENROLL, ENRHFSTUDSCHLYR, ENRHFSTUDENCODER, ENRHFSTUDTOTALUNITS, ENRHFSTUDSTATUS 
                FROM EnrollmentHeaderFile;", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var enrollmentHeader = new EnrollmentHeaderFile
                            {
                                ENRHFSTUDID = reader.GetInt64(reader.GetOrdinal("ENRHFSTUDID")),
                                ENRHFSTUDDATEENROLL = reader.GetDateTime(reader.GetOrdinal("ENRHFSTUDDATEENROLL")),
                                ENRHFSTUDSCHLYR = reader.GetString(reader.GetOrdinal("ENRHFSTUDSCHLYR")),
                                ENRHFSTUDENCODER = reader.GetString(reader.GetOrdinal("ENRHFSTUDENCODER")),
                                ENRHFSTUDTOTALUNITS = reader.GetDouble(reader.GetOrdinal("ENRHFSTUDTOTALUNITS")),
                                ENRHFSTUDSTATUS = reader.GetString(reader.GetOrdinal("ENRHFSTUDSTATUS"))
                            };
                            enrollmentHeaders.Add(enrollmentHeader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return enrollmentHeaders;
        }


        public DataTable GetEnrolledSubjects(long studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    string query = @"
                        SELECT 
                            ed.ENRDFSTUDID,  
                            ed.ENRDFSTUDSUBJCDE,  
                            sf.SFSUBJDESC,  
                            ed.ENRDFSTUDEDPCODE,  
                            ed.ENRDFSTUDSTATUS  
                        FROM EnrollmentDetailFile ed
                        JOIN SubjectFile sf ON ed.ENRDFSTUDSUBJCDE = sf.SFSUBJCODE
                        WHERE ed.ENRDFSTUDID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching enrolled subjects: " + ex.Message);
            }
            return dt;
        }

        public Result AddEnrollmentHeader(EnrollmentHeaderFile enrollmentHeader)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    string query = @"
                    INSERT INTO EnrollmentHeaderFile (
                        ENRHFSTUDID, 
                        ENRHFSTUDDATEENROLL, 
                        ENRHFSTUDSCHLYR, 
                        ENRHFSTUDENCODER, 
                        ENRHFSTUDTOTALUNITS, 
                        ENRHFSTUDSTATUS
                    ) VALUES (
                        @ENRHFSTUDID, 
                        @ENRHFSTUDDATEENROLL, 
                        @ENRHFSTUDSCHLYR, 
                        @ENRHFSTUDENCODER, 
                        @ENRHFSTUDTOTALUNITS, 
                        @ENRHFSTUDSTATUS
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ENRHFSTUDID", enrollmentHeader.ENRHFSTUDID);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDDATEENROLL", enrollmentHeader.ENRHFSTUDDATEENROLL);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDSCHLYR", enrollmentHeader.ENRHFSTUDSCHLYR);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDENCODER", enrollmentHeader.ENRHFSTUDENCODER);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDTOTALUNITS", enrollmentHeader.ENRHFSTUDTOTALUNITS);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDSTATUS", enrollmentHeader.ENRHFSTUDSTATUS);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return new Result { Success = true };
            }
            catch (Exception ex)
            {
                return new Result { Success = false, ErrorMessage = ex.Message };
            }
        }

        public Result DeleteEnrollmentHeader(long studentId)
        {
            var result = new Result();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
            DELETE FROM EnrollmentHeaderFile 
            WHERE ENRHFSTUDID = @ENRHFSTUDID;", connection))
                {
                    command.Parameters.Add(new SqlParameter("@ENRHFSTUDID", studentId));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
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

        public bool IsStudentEnrolled(long studentId)
        {
            bool isEnrolled = false;
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                SELECT COUNT(*) 
                FROM EnrollmentHeaderFile 
                WHERE ENRHFSTUDID = @ENRHFSTUDID;", connection))
                {
                    command.Parameters.Add(new SqlParameter("@ENRHFSTUDID", studentId));

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    isEnrolled = count > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return isEnrolled;
        }



        public sealed class Result
        {
            public bool Success { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
}
