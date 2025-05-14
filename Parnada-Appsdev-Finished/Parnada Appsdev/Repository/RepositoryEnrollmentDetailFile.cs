using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models;
using Parnada_Appsdev   .Repository;

namespace Parnada_Appsdev.Repository
{
    public class RepositoryEnrollmentDetailFile
    {
        public RepositoryResult AddEnrollmentDetail(EnrollmentDetailFile enrollmentDetail)
        {
            var result = new RepositoryResult();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                INSERT INTO EnrollmentDetailFile 
                (ENRDFSTUDID, ENRDFSTUDSUBJCDE, ENRDFSTUDEDPCODE, ENRDFSTUDSTATUS) 
                VALUES (@ENRDFSTUDID, @ENRDFSTUDSUBJCDE, @ENRDFSTUDEDPCODE, @ENRDFSTUDSTATUS);",
                    connection))
                {
                    var parameters = new Dictionary<string, object>
                    {
                        { "@ENRDFSTUDID", enrollmentDetail.ENRDFSTUDID },
                        { "@ENRDFSTUDSUBJCDE", enrollmentDetail.ENRDFSTUDSUBJCDE },
                        { "@ENRDFSTUDEDPCODE", enrollmentDetail.ENRDFSTUDEDPCODE },
                        { "@ENRDFSTUDSTATUS", enrollmentDetail.ENRDFSTUDSTATUS }
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

        public RepositoryResult DeleteEnrollmentDetail(long studentId, string subjectCode, string edpCode)
        {
            var result = new RepositoryResult();
            try
            {
                using (var connection = new SqlConnection(ConnectionString.GetConnectionString()))
                using (var command = new SqlCommand(@"
                DELETE FROM EnrollmentDetailFile 
                WHERE ENRDFSTUDID = @ENRDFSTUDID 
                AND ENRDFSTUDSUBJCDE = @ENRDFSTUDSUBJCDE 
                AND ENRDFSTUDEDPCODE = @ENRDFSTUDEDPCODE;",
                    connection))
                {
                    command.Parameters.Add(new SqlParameter("@ENRDFSTUDID", studentId));
                    command.Parameters.Add(new SqlParameter("@ENRDFSTUDSUBJCDE", subjectCode));
                    command.Parameters.Add(new SqlParameter("@ENRDFSTUDEDPCODE", edpCode));

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

    }
}
