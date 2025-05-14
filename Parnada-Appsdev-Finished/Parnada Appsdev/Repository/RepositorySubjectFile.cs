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
    public class RepositorySubjectFile
    {
        // Add a new subject
        public bool AddSubject(SubjectFile subject)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                string query = @"INSERT INTO SubjectFile 
                        (SFSUBJCODE, SFSUBJDESC, SFSUBJUNITS, SFSUBJREGOFRNG, 
                         SFSUBJCATEGORY, SFSUBJSTATUS, SFSUBJCOURSECODE, SFSUBJCURRCODE) 
                         VALUES (@SFSUBJCODE, @SFSUBJDESC, @SFSUBJUNITS, @SFSUBJREGOFRNG, @SFSUBJCATEGORY, @SFSUBJSTATUS, @SFSUBJCOURSECODE, @SFSUBJCURRCODE)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SFSUBJCODE", subject.SFSUBJCODE);
                cmd.Parameters.AddWithValue("@SFSUBJDESC", subject.SFSUBJDESC);
                cmd.Parameters.AddWithValue("@SFSUBJUNITS", subject.SFSUBJUNITS);
                cmd.Parameters.AddWithValue("@SFSUBJREGOFRNG", subject.SFSUBJREGOFRNG);
                cmd.Parameters.AddWithValue("@SFSUBJCATEGORY", subject.SFSUBJCATEGORY);
                cmd.Parameters.AddWithValue("@SFSUBJSTATUS", subject.SFSUBJSTATUS);
                cmd.Parameters.AddWithValue("@SFSUBJCOURSECODE", subject.SFSUBJCOURSECODE);
                cmd.Parameters.AddWithValue("@SFSUBJCURRCODE", subject.SFSUBJCURRCODE);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Update an existing subject
        public bool UpdateSubject(SubjectFile subject)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                string query = @"UPDATE SubjectFile SET 
                        SFSUBJDESC = @SFSUBJDESC, 
                        SFSUBJUNITS = @SFSUBJUNITS, 
                        SFSUBJREGOFRNG = @SFSUBJREGOFRNG, 
                        SFSUBJCATEGORY = @SFSUBJCATEGORY, 
                        SFSUBJSTATUS = @SFSUBJSTATUS, 
                        SFSUBJCURRCODE = @SFSUBJCURRCODE
                        WHERE SFSUBJCODE = @SFSUBJCODE AND SFSUBJCOURSECODE = @SFSUBJCOURSECODE";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SFSUBJCODE", subject.SFSUBJCODE);
                cmd.Parameters.AddWithValue("@SFSUBJDESC", subject.SFSUBJDESC);
                cmd.Parameters.AddWithValue("@SFSUBJUNITS", subject.SFSUBJUNITS);
                cmd.Parameters.AddWithValue("@SFSUBJREGOFRNG", subject.SFSUBJREGOFRNG);
                cmd.Parameters.AddWithValue("@SFSUBJCATEGORY", subject.SFSUBJCATEGORY);
                cmd.Parameters.AddWithValue("@SFSUBJSTATUS", subject.SFSUBJSTATUS);
                cmd.Parameters.AddWithValue("@SFSUBJCOURSECODE", subject.SFSUBJCOURSECODE);
                cmd.Parameters.AddWithValue("@SFSUBJCURRCODE", subject.SFSUBJCURRCODE);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<SubjectFile> GetAllSubjects()
        {
            List<SubjectFile> subjects = new List<SubjectFile>();

            using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM SubjectFile";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new SubjectFile
                        {
                            SFSUBJCODE = reader["SFSUBJCODE"].ToString(),
                            SFSUBJDESC = reader["SFSUBJDESC"].ToString(),
                            SFSUBJUNITS = Convert.ToSingle(reader["SFSUBJUNITS"]),
                            SFSUBJREGOFRNG = Convert.ToInt32(reader["SFSUBJREGOFRNG"]),
                            SFSUBJCATEGORY = reader["SFSUBJCATEGORY"].ToString(),
                            SFSUBJSTATUS = reader["SFSUBJSTATUS"].ToString(),
                            SFSUBJCOURSECODE = reader["SFSUBJCOURSECODE"].ToString(),
                            SFSUBJCURRCODE = reader["SFSUBJCURRCODE"].ToString()
                        });
                    }
                }
            }
            return subjects;
        }

        public bool DeleteSubject(string subjectCode, string courseCode)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                string query = "DELETE FROM SubjectFile WHERE SFSUBJCODE = @Code AND SFSUBJCOURSECODE = @Course";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", subjectCode);
                cmd.Parameters.AddWithValue("@Course", courseCode);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //  Dispay subjects in a DataTable
        public DataTable GetSubjects()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    connection.Open();
                    string sql = "SELECT * FROM SubjectFile;";
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
}
