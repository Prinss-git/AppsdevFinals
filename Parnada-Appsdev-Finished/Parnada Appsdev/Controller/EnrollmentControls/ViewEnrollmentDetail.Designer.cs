namespace Parnada_Appsdev.Controller.EnrollmentControls
{
    partial class ViewEnrollmentDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnGradeDelete = new MaterialSkin.Controls.MaterialButton();
            this.dgvGradingSubjects = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnStudentDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnGradeSubject = new MaterialSkin.Controls.MaterialButton();
            this.dgvEnrolledSubjects = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradingSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledSubjects)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnGradeDelete);
            this.materialCard1.Controls.Add(this.dgvGradingSubjects);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.btnStudentDelete);
            this.materialCard1.Controls.Add(this.btnGradeSubject);
            this.materialCard1.Controls.Add(this.dgvEnrolledSubjects);
            this.materialCard1.Controls.Add(this.flowLayoutPanel3);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(954, 636);
            this.materialCard1.TabIndex = 19;
            // 
            // btnGradeDelete
            // 
            this.btnGradeDelete.AutoSize = false;
            this.btnGradeDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGradeDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnGradeDelete.Depth = 0;
            this.btnGradeDelete.DrawShadows = false;
            this.btnGradeDelete.HighEmphasis = false;
            this.btnGradeDelete.Icon = global::Parnada_Appsdev.Properties.Resources.remove_user;
            this.btnGradeDelete.Location = new System.Drawing.Point(775, 339);
            this.btnGradeDelete.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGradeDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGradeDelete.Name = "btnGradeDelete";
            this.btnGradeDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGradeDelete.Size = new System.Drawing.Size(135, 32);
            this.btnGradeDelete.TabIndex = 61;
            this.btnGradeDelete.Text = "Delete";
            this.btnGradeDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnGradeDelete.UseAccentColor = false;
            this.btnGradeDelete.UseVisualStyleBackColor = true;
            this.btnGradeDelete.Click += new System.EventHandler(this.btnGradeDelete_Click);
            // 
            // dgvGradingSubjects
            // 
            this.dgvGradingSubjects.AllowUserToAddRows = false;
            this.dgvGradingSubjects.AllowUserToDeleteRows = false;
            this.dgvGradingSubjects.AllowUserToResizeColumns = false;
            this.dgvGradingSubjects.AllowUserToResizeRows = false;
            this.dgvGradingSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGradingSubjects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGradingSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGradingSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGradingSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGradingSubjects.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGradingSubjects.EnableHeadersVisualStyles = false;
            this.dgvGradingSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvGradingSubjects.Location = new System.Drawing.Point(40, 396);
            this.dgvGradingSubjects.MultiSelect = false;
            this.dgvGradingSubjects.Name = "dgvGradingSubjects";
            this.dgvGradingSubjects.ReadOnly = true;
            this.dgvGradingSubjects.RowHeadersVisible = false;
            this.dgvGradingSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradingSubjects.Size = new System.Drawing.Size(870, 148);
            this.dgvGradingSubjects.TabIndex = 60;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(40, 339);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(257, 24);
            this.materialLabel2.TabIndex = 59;
            this.materialLabel2.Text = "Graded Subjects Information";
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.AutoSize = false;
            this.btnStudentDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnStudentDelete.Depth = 0;
            this.btnStudentDelete.DrawShadows = false;
            this.btnStudentDelete.HighEmphasis = false;
            this.btnStudentDelete.Icon = global::Parnada_Appsdev.Properties.Resources.remove_user;
            this.btnStudentDelete.Location = new System.Drawing.Point(774, 101);
            this.btnStudentDelete.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStudentDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStudentDelete.Size = new System.Drawing.Size(135, 32);
            this.btnStudentDelete.TabIndex = 58;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnStudentDelete.UseAccentColor = false;
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnGradeSubject
            // 
            this.btnGradeSubject.AutoSize = false;
            this.btnGradeSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGradeSubject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnGradeSubject.Depth = 0;
            this.btnGradeSubject.DrawShadows = false;
            this.btnGradeSubject.HighEmphasis = false;
            this.btnGradeSubject.Icon = global::Parnada_Appsdev.Properties.Resources.grade;
            this.btnGradeSubject.Location = new System.Drawing.Point(583, 103);
            this.btnGradeSubject.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGradeSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGradeSubject.Name = "btnGradeSubject";
            this.btnGradeSubject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGradeSubject.Size = new System.Drawing.Size(181, 32);
            this.btnGradeSubject.TabIndex = 57;
            this.btnGradeSubject.Text = "Grade Subject";
            this.btnGradeSubject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnGradeSubject.UseAccentColor = false;
            this.btnGradeSubject.UseVisualStyleBackColor = true;
            this.btnGradeSubject.Click += new System.EventHandler(this.btnGradeSubject_Click);
            // 
            // dgvEnrolledSubjects
            // 
            this.dgvEnrolledSubjects.AllowUserToAddRows = false;
            this.dgvEnrolledSubjects.AllowUserToDeleteRows = false;
            this.dgvEnrolledSubjects.AllowUserToResizeColumns = false;
            this.dgvEnrolledSubjects.AllowUserToResizeRows = false;
            this.dgvEnrolledSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrolledSubjects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEnrolledSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEnrolledSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEnrolledSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnrolledSubjects.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEnrolledSubjects.EnableHeadersVisualStyles = false;
            this.dgvEnrolledSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvEnrolledSubjects.Location = new System.Drawing.Point(40, 160);
            this.dgvEnrolledSubjects.MultiSelect = false;
            this.dgvEnrolledSubjects.Name = "dgvEnrolledSubjects";
            this.dgvEnrolledSubjects.ReadOnly = true;
            this.dgvEnrolledSubjects.RowHeadersVisible = false;
            this.dgvEnrolledSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrolledSubjects.Size = new System.Drawing.Size(870, 148);
            this.dgvEnrolledSubjects.TabIndex = 55;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.btnCancel);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(822, 573);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(87, 36);
            this.flowLayoutPanel3.TabIndex = 52;
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(40, 103);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(264, 24);
            this.materialLabel1.TabIndex = 47;
            this.materialLabel1.Text = "Enrolled Subjects Information";
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
            this.materialLabel3.Size = new System.Drawing.Size(258, 41);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "Enrollment Detail";
            // 
            // ViewEnrollmentDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewEnrollmentDetail";
            this.Size = new System.Drawing.Size(994, 676);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradingSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledSubjects)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView dgvEnrolledSubjects;
        private MaterialSkin.Controls.MaterialButton btnGradeSubject;
        private MaterialSkin.Controls.MaterialButton btnStudentDelete;
        private MaterialSkin.Controls.MaterialButton btnGradeDelete;
        private System.Windows.Forms.DataGridView dgvGradingSubjects;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
