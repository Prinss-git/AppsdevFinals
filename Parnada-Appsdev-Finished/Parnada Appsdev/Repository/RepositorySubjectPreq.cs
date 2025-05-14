using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models;

namespace Parnada_Appsdev.Repository
{
    public class RepositorySubjectPreq
    {
        public bool AddSubjectPreq(SubjectPreqFile subjectPreq)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                string query = @"INSERT INTO SubjectPreqFile (SUBJCODE, SUBJPRECODE, SUBJCATEGORY) 
                             VALUES (@SUBJCODE, @SUBJPRECODE, @SUBJCATEGORY)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SUBJCODE", subjectPreq.SUBJCODE);
                cmd.Parameters.AddWithValue("@SUBJPRECODE", subjectPreq.SUBJPRECODE);
                cmd.Parameters.AddWithValue("@SUBJCATEGORY", subjectPreq.SUBJCATEGORY);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateSubjectPreq(SubjectPreqFile subjectPreq)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                string query = @"UPDATE SubjectPreqFile 
                         SET SUBJCATEGORY = @SUBJCATEGORY
                         WHERE SUBJCODE = @SUBJCODE AND SUBJPRECODE = @SUBJPRECODE";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SUBJCODE", subjectPreq.SUBJCODE);
                cmd.Parameters.AddWithValue("@SUBJPRECODE", subjectPreq.SUBJPRECODE);
                cmd.Parameters.AddWithValue("@SUBJCATEGORY", subjectPreq.SUBJCATEGORY);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteSubjectPreq(string subjCode, string subjPreCode)
        {   
            using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                string query = @"DELETE FROM SubjectPreqFile 
                         WHERE SUBJCODE = @SUBJCODE AND SUBJPRECODE = @SUBJPRECODE";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SUBJCODE", subjCode);
                cmd.Parameters.AddWithValue("@SUBJPRECODE", subjPreCode);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetSubjectPreq()
        {
            DataTable dt = new DataTable();
            try
            {   
                using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    connection.Open();
                    string sql = "SELECT SUBJCODE, SUBJPRECODE, SUBJCATEGORY FROM SubjectPreqFile;";
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

        public bool IsSubjectPreqExists(string subjCode, string subjPreCode)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    string query = "SELECT COUNT(*) FROM SubjectPreqFile WHERE SUBJCODE = @SUBJCODE AND SUBJPRECODE = @SUBJPRECODE";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SUBJCODE", subjCode);
                        cmd.Parameters.AddWithValue("@SUBJPRECODE", subjPreCode);
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
