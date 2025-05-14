namespace Parnada_Appsdev.Controller.EnrollmentControls
{
    partial class EnrollStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollStudent));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.clbSubjects = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEnroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbStudentID = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpDateEnroll = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpYear = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboEncoder = new MaterialSkin.Controls.MaterialComboBox();
            this.cboStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.clbSubjects);
            this.materialCard1.Controls.Add(this.flowLayoutPanel3);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.flowLayoutPanel2);
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
            this.materialCard1.TabIndex = 18;
            // 
            // clbSubjects
            // 
            this.clbSubjects.FormattingEnabled = true;
            this.clbSubjects.Location = new System.Drawing.Point(40, 328);
            this.clbSubjects.Name = "clbSubjects";
            this.clbSubjects.Size = new System.Drawing.Size(870, 214);
            this.clbSubjects.TabIndex = 53;
            this.clbSubjects.ThreeDCheckBoxes = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.btnEnroll);
            this.flowLayoutPanel3.Controls.Add(this.btnCancel);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(726, 573);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(184, 36);
            this.flowLayoutPanel3.TabIndex = 52;
            // 
            // btnEnroll
            // 
            this.btnEnroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnEnroll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.ForeColor = System.Drawing.Color.White;
            this.btnEnroll.Location = new System.Drawing.Point(97, 0);
            this.btnEnroll.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(87, 36);
            this.btnEnroll.TabIndex = 45;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tbStudentID);
            this.flowLayoutPanel1.Controls.Add(this.dtpDateEnroll);
            this.flowLayoutPanel1.Controls.Add(this.dtpYear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 165);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(820, 49);
            this.flowLayoutPanel1.TabIndex = 51;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // tbStudentID
            // 
            this.tbStudentID.AnimateReadOnly = true;
            this.tbStudentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbStudentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbStudentID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbStudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbStudentID.Depth = 0;
            this.tbStudentID.Enabled = false;
            this.tbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbStudentID.HideSelection = true;
            this.tbStudentID.Hint = "Student ID";
            this.tbStudentID.LeadingIcon = null;
            this.tbStudentID.Location = new System.Drawing.Point(0, 0);
            this.tbStudentID.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.tbStudentID.MaxLength = 32767;
            this.tbStudentID.MouseState = MaterialSkin.MouseState.OUT;
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.PasswordChar = '\0';
            this.tbStudentID.PrefixSuffixText = null;
            this.tbStudentID.ReadOnly = false;
            this.tbStudentID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbStudentID.SelectedText = "";
            this.tbStudentID.SelectionLength = 0;
            this.tbStudentID.SelectionStart = 0;
            this.tbStudentID.ShortcutsEnabled = true;
            this.tbStudentID.Size = new System.Drawing.Size(240, 48);
            this.tbStudentID.TabIndex = 46;
            this.tbStudentID.TabStop = false;
            this.tbStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbStudentID.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("tbStudentID.TrailingIcon")));
            this.tbStudentID.UseSystemPasswordChar = false;
            // 
            // dtpDateEnroll
            // 
            this.dtpDateEnroll.Checked = true;
            this.dtpDateEnroll.FillColor = System.Drawing.SystemColors.Control;
            this.dtpDateEnroll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateEnroll.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateEnroll.Location = new System.Drawing.Point(290, 0);
            this.dtpDateEnroll.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.dtpDateEnroll.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateEnroll.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateEnroll.Name = "dtpDateEnroll";
            this.dtpDateEnroll.Size = new System.Drawing.Size(240, 49);
            this.dtpDateEnroll.TabIndex = 52;
            this.dtpDateEnroll.Value = new System.DateTime(2025, 3, 21, 20, 46, 50, 278);
            // 
            // dtpYear
            // 
            this.dtpYear.Checked = true;
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.FillColor = System.Drawing.SystemColors.Control;
            this.dtpYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(580, 0);
            this.dtpYear.Margin = new System.Windows.Forms.Padding(0);
            this.dtpYear.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpYear.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.ShowUpDown = true;
            this.dtpYear.Size = new System.Drawing.Size(240, 49);
            this.dtpYear.TabIndex = 59;
            this.dtpYear.Value = new System.DateTime(2025, 3, 21, 12, 12, 43, 953);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.cboEncoder);
            this.flowLayoutPanel2.Controls.Add(this.cboStatus);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(40, 243);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(530, 49);
            this.flowLayoutPanel2.TabIndex = 49;
            this.flowLayoutPanel2.TabStop = true;
            // 
            // cboEncoder
            // 
            this.cboEncoder.AutoResize = false;
            this.cboEncoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboEncoder.Depth = 0;
            this.cboEncoder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEncoder.DropDownHeight = 174;
            this.cboEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncoder.DropDownWidth = 121;
            this.cboEncoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEncoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEncoder.FormattingEnabled = true;
            this.cboEncoder.Hint = "Student Encoder";
            this.cboEncoder.IntegralHeight = false;
            this.cboEncoder.ItemHeight = 43;
            this.cboEncoder.Items.AddRange(new object[] {
            "Admin01",
            "Admin02",
            "Admin03",
            "Staff01",
            "Staff02",
            "Staff03"});
            this.cboEncoder.Location = new System.Drawing.Point(0, 0);
            this.cboEncoder.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.cboEncoder.MaxDropDownItems = 4;
            this.cboEncoder.MouseState = MaterialSkin.MouseState.OUT;
            this.cboEncoder.Name = "cboEncoder";
            this.cboEncoder.Size = new System.Drawing.Size(240, 49);
            this.cboEncoder.StartIndex = 0;
            this.cboEncoder.TabIndex = 51;
            // 
            // cboStatus
            // 
            this.cboStatus.AutoResize = false;
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStatus.Depth = 0;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboStatus.DropDownHeight = 174;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.DropDownWidth = 121;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Hint = "Status";
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.ItemHeight = 43;
            this.cboStatus.Items.AddRange(new object[] {
            "Enrolled",
            "Unenrolled"});
            this.cboStatus.Location = new System.Drawing.Point(290, 0);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboStatus.MaxDropDownItems = 4;
            this.cboStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(240, 49);
            this.cboStatus.StartIndex = 0;
            this.cboStatus.TabIndex = 53;
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
            this.materialLabel1.Size = new System.Drawing.Size(180, 24);
            this.materialLabel1.TabIndex = 47;
            this.materialLabel1.Text = "Student Information";
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
            this.materialLabel3.Size = new System.Drawing.Size(249, 41);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "Enrollment Entry";
            // 
            // EnrollStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EnrollStudent";
            this.Size = new System.Drawing.Size(994, 676);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 tbStudentID;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpYear;
        private MaterialSkin.Controls.MaterialComboBox cboEncoder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateEnroll;
        private MaterialSkin.Controls.MaterialComboBox cboStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btnEnroll;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.CheckedListBox clbSubjects;
    }
}
