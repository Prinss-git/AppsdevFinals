using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models;
using Parnada_Appsdev.Models.Parnada_Appsdev.Models;

namespace Parnada_Appsdev.Repository
{
    public class RepositorySubjectSched
    {
        private bool HasTimeConflict(SubjectSchedFile newSchedule)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    string query = @"SELECT COUNT(*) FROM SubjectSchedFile 
                                   WHERE SSFDAYS = @SSFDAYS 
                                   AND SSFROOM = @SSFROOM
                                   AND (
                                       (@SSFSTARTTIME BETWEEN SSFSTARTTIME AND SSFENDTIME)
                                       OR (@SSFENDTIME BETWEEN SSFSTARTTIME AND SSFENDTIME)
                                       OR (SSFSTARTTIME BETWEEN @SSFSTARTTIME AND @SSFENDTIME)
                                   )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SSFDAYS", newSchedule.SSFDAYS);
                        cmd.Parameters.AddWithValue("@SSFROOM", newSchedule.SSFROOM);
                        cmd.Parameters.AddWithValue("@SSFSTARTTIME", newSchedule.SSFSTARTTIME);
                        cmd.Parameters.AddWithValue("@SSFENDTIME", newSchedule.SSFENDTIME);

                        conn.Open();
                        int conflictCount = (int)cmd.ExecuteScalar();
                        return conflictCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for time conflicts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Return true to prevent adding in case of error
            }
        }

        public bool AddSubjectSched(SubjectSchedFile subjectSchedFile)
        {
            try
            {
                if (HasTimeConflict(subjectSchedFile))
                {
                    MessageBox.Show("Time conflict detected! This schedule conflicts with an existing schedule in the same room and day. Please adjust the time or room.",
                        "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    string query = @"INSERT INTO SubjectSchedFile 
                    (SSFEDPCODE, SSFSUBJCODE, SSFSTARTTIME, SSFENDTIME, SSFDAYS, SSFROOM, 
                     SSFMAXSIZE, SSFCLASSSIZE, SSFSTATUS, SSFXM, SSFSECTION, SSFSCHOOLYEAR) 
                     VALUES (@SSFEDPCODE, @SSFSUBJCODE, @SSFSTARTTIME, @SSFENDTIME, @SSFDAYS, 
                             @SSFROOM, @SSFMAXSIZE, @SSFCLASSSIZE, @SSFSTATUS, @SSFXM, @SSFSECTION, @SSFSCHOOLYEAR)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SSFEDPCODE", subjectSchedFile.SSFEDPCODE);
                    cmd.Parameters.AddWithValue("@SSFSUBJCODE", subjectSchedFile.SSFSUBJCODE);
                    cmd.Parameters.AddWithValue("@SSFSTARTTIME", subjectSchedFile.SSFSTARTTIME);
                    cmd.Parameters.AddWithValue("@SSFENDTIME", subjectSchedFile.SSFENDTIME);
                    cmd.Parameters.AddWithValue("@SSFDAYS", subjectSchedFile.SSFDAYS);
                    cmd.Parameters.AddWithValue("@SSFROOM", subjectSchedFile.SSFROOM);
                    cmd.Parameters.AddWithValue("@SSFMAXSIZE", subjectSchedFile.SSFMAXSIZE);
                    cmd.Parameters.AddWithValue("@SSFCLASSSIZE", subjectSchedFile.SSFCLASSSIZE);
                    cmd.Parameters.AddWithValue("@SSFSTATUS", subjectSchedFile.SSFSTATUS);
                    cmd.Parameters.AddWithValue("@SSFXM", subjectSchedFile.SSFXM);
                    cmd.Parameters.AddWithValue("@SSFSECTION", subjectSchedFile.SSFSECTION);
                    cmd.Parameters.AddWithValue("@SSFSCHOOLYEAR", subjectSchedFile.SSFSCHOOLYEAR);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding subject schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateSubjectSched(SubjectSchedFile subjectSchedFile)
        {
            try
            {
                if (HasTimeConflict(subjectSchedFile))
                {
                    MessageBox.Show("Time conflict detected! This schedule conflicts with an existing schedule in the same room and day. Please adjust the time or room.",
                        "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    string query = @"UPDATE SubjectSchedFile SET 
                            SSFSUBJCODE = @SSFSUBJCODE, 
                            SSFSTARTTIME = @SSFSTARTTIME, 
                            SSFENDTIME = @SSFENDTIME, 
                            SSFDAYS = @SSFDAYS, 
                            SSFROOM = @SSFROOM, 
                            SSFMAXSIZE = @SSFMAXSIZE, 
                            SSFCLASSSIZE = @SSFCLASSSIZE, 
                            SSFSTATUS = @SSFSTATUS, 
                            SSFXM = @SSFXM, 
                            SSFSECTION = @SSFSECTION, 
                            SSFSCHOOLYEAR = @SSFSCHOOLYEAR 
                            WHERE SSFEDPCODE = @SSFEDPCODE";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SSFEDPCODE", subjectSchedFile.SSFEDPCODE);
                    cmd.Parameters.AddWithValue("@SSFSUBJCODE", subjectSchedFile.SSFSUBJCODE);
                    cmd.Parameters.AddWithValue("@SSFSTARTTIME", subjectSchedFile.SSFSTARTTIME);
                    cmd.Parameters.AddWithValue("@SSFENDTIME", subjectSchedFile.SSFENDTIME);
                    cmd.Parameters.AddWithValue("@SSFDAYS", subjectSchedFile.SSFDAYS);
                    cmd.Parameters.AddWithValue("@SSFROOM", subjectSchedFile.SSFROOM);
                    cmd.Parameters.AddWithValue("@SSFMAXSIZE", subjectSchedFile.SSFMAXSIZE);
                    cmd.Parameters.AddWithValue("@SSFCLASSSIZE", subjectSchedFile.SSFCLASSSIZE);
                    cmd.Parameters.AddWithValue("@SSFSTATUS", subjectSchedFile.SSFSTATUS);
                    cmd.Parameters.AddWithValue("@SSFXM", subjectSchedFile.SSFXM);
                    cmd.Parameters.AddWithValue("@SSFSECTION", subjectSchedFile.SSFSECTION);
                    cmd.Parameters.AddWithValue("@SSFSCHOOLYEAR", subjectSchedFile.SSFSCHOOLYEAR);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating subject schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteSubjectSched(string edpCode)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                string query = "DELETE FROM SubjectSchedFile WHERE SSFEDPCODE = @SSFEDPCODE";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SSFEDPCODE", edpCode);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0; // Returns true if at least one row is deleted
                }
            }
        }

        //  Dispay subjects in a DataTable
        public DataTable GetSubjectsSched()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    connection.Open();
                    string sql = @"
                 SELECT ss.*, sf.SFSUBJUNITS, sf.SFSUBJDESC 
                 FROM SubjectSchedFile ss
                 LEFT JOIN SubjectFile sf ON ss.SSFSUBJCODE = sf.SFSUBJCODE";

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

        public bool IsSubjectSchedExists(string edpCode)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    string query = "SELECT COUNT(*) FROM SubjectSchedFile WHERE SSFEDPCODE = @SSFEDPCODE";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SSFEDPCODE", edpCode);
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
