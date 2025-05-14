using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models;

namespace Parnada_Appsdev.Repository
{
    public class RepositoryStudentGradeFile
    {
        public List<StudentGradeFile> GetAllStudentGrades()
        {
            var studentGrades = new List<StudentGradeFile>();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                    SELECT SGFSTUDID, SGFSTUDSUBJCODE, SGFSTUDSUBJGRADE, SGFSTUDEDPCODE, SGFSTUDREMARKS 
                    FROM StudentGradeFile;", connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var studentGrade = new StudentGradeFile
                            {
                                SGFSTUDID = reader.GetInt64(reader.GetOrdinal("SGFSTUDID")),
                                SGFSTUDSUBJCODE = reader.GetString(reader.GetOrdinal("SGFSTUDSUBJCODE")),
                                SGFSTUDSUBJGRADE = reader.GetDouble(reader.GetOrdinal("SGFSTUDSUBJGRADE")),
                                SGFSTUDEDPCODE = reader.GetString(reader.GetOrdinal("SGFSTUDEDPCODE")),
                                SGFSTUDREMARKS = reader.IsDBNull(reader.GetOrdinal("SGFSTUDREMARKS")) ? null : reader.GetString(reader.GetOrdinal("SGFSTUDREMARKS"))
                            };
                            studentGrades.Add(studentGrade);
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
            return studentGrades;
        }

        public RepositoryResult AddStudentGrade(StudentGradeFile studentGrade)
        {
            var result = new RepositoryResult();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                INSERT INTO StudentGradeFile 
                (SGFSTUDID, SGFSTUDSUBJCODE, SGFSTUDSUBJGRADE, SGFSTUDEDPCODE, SGFSTUDREMARKS) 
                VALUES (@SGFSTUDID, @SGFSTUDSUBJCODE, @SGFSTUDSUBJGRADE, @SGFSTUDEDPCODE, @SGFSTUDREMARKS);",
                    connection))
                {
                    var parameters = new Dictionary<string, object>
                    {
                        { "@SGFSTUDID", studentGrade.SGFSTUDID },
                        { "@SGFSTUDSUBJCODE", studentGrade.SGFSTUDSUBJCODE },
                        { "@SGFSTUDSUBJGRADE", studentGrade.SGFSTUDSUBJGRADE },
                        { "@SGFSTUDEDPCODE", studentGrade.SGFSTUDEDPCODE },
                        { "@SGFSTUDREMARKS", studentGrade.SGFSTUDREMARKS }
                    };

                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(param.Key, param.Value ?? DBNull.Value));
                    }

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

        public RepositoryResult DeleteStudentGrade(long studentId, string subjectCode, string edpCode)
        {
            var result = new RepositoryResult();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                DELETE FROM StudentGradeFile 
                WHERE SGFSTUDID = @SGFSTUDID 
                AND SGFSTUDSUBJCODE = @SGFSTUDSUBJCODE 
                AND SGFSTUDEDPCODE = @SGFSTUDEDPCODE;", connection))
                {
                    command.Parameters.Add(new SqlParameter("@SGFSTUDID", studentId));
                    command.Parameters.Add(new SqlParameter("@SGFSTUDSUBJCODE", subjectCode));
                    command.Parameters.Add(new SqlParameter("@SGFSTUDEDPCODE", edpCode));

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

        public class RepositoryResult
        {
            public bool Success { get; set; }
            public string ErrorMessage { get; set; }
        }

        public List<StudentGradeFile> GetStudentGradesBySubject(long studentId)
        {
            var studentGrades = new List<StudentGradeFile>();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                SELECT SGFSTUDID, SGFSTUDSUBJCODE, SGFSTUDSUBJGRADE, SGFSTUDEDPCODE, SGFSTUDREMARKS 
                FROM StudentGradeFile
                WHERE SGFSTUDID = @SGFSTUDID;", connection))
                {
                    command.Parameters.Add(new SqlParameter("@SGFSTUDID", studentId));

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var studentGrade = new StudentGradeFile
                            {
                                SGFSTUDID = reader.GetInt64(reader.GetOrdinal("SGFSTUDID")),
                                SGFSTUDSUBJCODE = reader.GetString(reader.GetOrdinal("SGFSTUDSUBJCODE")),
                                SGFSTUDSUBJGRADE = reader.GetDouble(reader.GetOrdinal("SGFSTUDSUBJGRADE")),
                                SGFSTUDEDPCODE = reader.GetString(reader.GetOrdinal("SGFSTUDEDPCODE")),
                                SGFSTUDREMARKS = reader.IsDBNull(reader.GetOrdinal("SGFSTUDREMARKS")) ? null : reader.GetString(reader.GetOrdinal("SGFSTUDREMARKS"))
                            };
                            studentGrades.Add(studentGrade);
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
            return studentGrades;
        }

        public List<StudentGradeFile> GetStudentGradesPrimary(long studentId, string subjectCode, string edpCode)
        {
            var studentGrades = new List<StudentGradeFile>();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                SELECT SGFSTUDID, SGFSTUDSUBJCODE, SGFSTUDSUBJGRADE, SGFSTUDEDPCODE, SGFSTUDREMARKS 
                FROM StudentGradeFile
                WHERE SGFSTUDID = @SGFSTUDID 
                AND SGFSTUDSUBJCODE = @SGFSTUDSUBJCODE 
                AND SGFSTUDEDPCODE = @SGFSTUDEDPCODE;", connection))
                {
                    command.Parameters.Add(new SqlParameter("@SGFSTUDID", studentId));
                    command.Parameters.Add(new SqlParameter("@SGFSTUDSUBJCODE", subjectCode));
                    command.Parameters.Add(new SqlParameter("@SGFSTUDEDPCODE", edpCode));

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var studentGrade = new StudentGradeFile
                            {
                                SGFSTUDID = reader.GetInt64(reader.GetOrdinal("SGFSTUDID")),
                                SGFSTUDSUBJCODE = reader.GetString(reader.GetOrdinal("SGFSTUDSUBJCODE")),
                                SGFSTUDSUBJGRADE = reader.GetDouble(reader.GetOrdinal("SGFSTUDSUBJGRADE")),
                                SGFSTUDEDPCODE = reader.GetString(reader.GetOrdinal("SGFSTUDEDPCODE")),
                                SGFSTUDREMARKS = reader.IsDBNull(reader.GetOrdinal("SGFSTUDREMARKS")) ? null : reader.GetString(reader.GetOrdinal("SGFSTUDREMARKS"))
                            };
                            studentGrades.Add(studentGrade);
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
            return studentGrades;
        }




    }
}
