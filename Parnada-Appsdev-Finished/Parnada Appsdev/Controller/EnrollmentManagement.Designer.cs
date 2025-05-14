namespace Parnada_Appsdev.Controller
{
    partial class EnrollmentManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEnrollStudent = new MaterialSkin.Controls.MaterialButton();
            this.btnViewEnrollmentDetail = new MaterialSkin.Controls.MaterialButton();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnViewEnrolledStudents = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.dgvStudents);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(954, 636);
            this.materialCard1.TabIndex = 17;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(37, 26);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(374, 41);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "Enrollment Management";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnEnrollStudent);
            this.flowLayoutPanel1.Controls.Add(this.btnViewEnrollmentDetail);
            this.flowLayoutPanel1.Controls.Add(this.btnViewEnrolledStudents);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(229, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(681, 32);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnEnrollStudent
            // 
            this.btnEnrollStudent.AutoSize = false;
            this.btnEnrollStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnrollStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnEnrollStudent.Depth = 0;
            this.btnEnrollStudent.DrawShadows = false;
            this.btnEnrollStudent.HighEmphasis = false;
            this.btnEnrollStudent.Icon = global::Parnada_Appsdev.Properties.Resources.add;
            this.btnEnrollStudent.Location = new System.Drawing.Point(506, 0);
            this.btnEnrollStudent.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEnrollStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnrollStudent.Name = "btnEnrollStudent";
            this.btnEnrollStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEnrollStudent.Size = new System.Drawing.Size(175, 32);
            this.btnEnrollStudent.TabIndex = 15;
            this.btnEnrollStudent.Text = "Enroll Student";
            this.btnEnrollStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnEnrollStudent.UseAccentColor = false;
            this.btnEnrollStudent.UseVisualStyleBackColor = true;
            this.btnEnrollStudent.Click += new System.EventHandler(this.btnEnrollStudent_Click);
            // 
            // btnViewEnrollmentDetail
            // 
            this.btnViewEnrollmentDetail.AutoSize = false;
            this.btnViewEnrollmentDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewEnrollmentDetail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnViewEnrollmentDetail.Depth = 0;
            this.btnViewEnrollmentDetail.DrawShadows = false;
            this.btnViewEnrollmentDetail.HighEmphasis = false;
            this.btnViewEnrollmentDetail.Icon = global::Parnada_Appsdev.Properties.Resources.search_file;
            this.btnViewEnrollmentDetail.Location = new System.Drawing.Point(253, 0);
            this.btnViewEnrollmentDetail.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnViewEnrollmentDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewEnrollmentDetail.Name = "btnViewEnrollmentDetail";
            this.btnViewEnrollmentDetail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewEnrollmentDetail.Size = new System.Drawing.Size(233, 32);
            this.btnViewEnrollmentDetail.TabIndex = 16;
            this.btnViewEnrollmentDetail.Text = "View Enrollment Detail";
            this.btnViewEnrollmentDetail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnViewEnrollmentDetail.UseAccentColor = false;
            this.btnViewEnrollmentDetail.UseVisualStyleBackColor = true;
            this.btnViewEnrollmentDetail.Click += new System.EventHandler(this.btnViewEnrollmentDetail_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvStudents.Location = new System.Drawing.Point(40, 204);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(870, 393);
            this.dgvStudents.TabIndex = 12;
            // 
            // btnViewEnrolledStudents
            // 
            this.btnViewEnrolledStudents.AutoSize = false;
            this.btnViewEnrolledStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewEnrolledStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnViewEnrolledStudents.Depth = 0;
            this.btnViewEnrolledStudents.DrawShadows = false;
            this.btnViewEnrolledStudents.HighEmphasis = false;
            this.btnViewEnrolledStudents.Icon = global::Parnada_Appsdev.Properties.Resources.info;
            this.btnViewEnrolledStudents.Location = new System.Drawing.Point(0, 0);
            this.btnViewEnrolledStudents.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewEnrolledStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewEnrolledStudents.Name = "btnViewEnrolledStudents";
            this.btnViewEnrolledStudents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewEnrolledStudents.Size = new System.Drawing.Size(233, 32);
            this.btnViewEnrolledStudents.TabIndex = 17;
            this.btnViewEnrolledStudents.Text = "View Enrolled Students";
            this.btnViewEnrolledStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnViewEnrolledStudents.UseAccentColor = false;
            this.btnViewEnrolledStudents.UseVisualStyleBackColor = true;
            this.btnViewEnrolledStudents.Click += new System.EventHandler(this.btnViewEnrolledStudents_Click);
            // 
            // EnrollmentManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EnrollmentManagement";
            this.Size = new System.Drawing.Size(994, 676);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnEnrollStudent;
        private MaterialSkin.Controls.MaterialButton btnViewEnrollmentDetail;
        private System.Windows.Forms.DataGridView dgvStudents;
        private MaterialSkin.Controls.MaterialButton btnViewEnrolledStudents;
    }
}
