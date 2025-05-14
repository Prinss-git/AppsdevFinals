namespace Parnada_Appsdev.Controller.SubjectControls
{
    partial class SubjectEdit
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSubjectCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbDescription = new MaterialSkin.Controls.MaterialTextBox2();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.numUnits = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cboOffering = new MaterialSkin.Controls.MaterialComboBox();
            this.cboCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.cboCourseCode = new MaterialSkin.Controls.MaterialComboBox();
            this.tbCurriculumCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.flowLayoutPanel5);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(954, 636);
            this.materialCard1.TabIndex = 40;
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
            this.materialLabel1.Size = new System.Drawing.Size(177, 24);
            this.materialLabel1.TabIndex = 53;
            this.materialLabel1.Text = "Subject Information";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel2.Location = new System.Drawing.Point(45, 242);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(23, 13);
            this.materialLabel2.TabIndex = 52;
            this.materialLabel2.Text = "Units";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(40, 180);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(820, 285);
            this.flowLayoutPanel5.TabIndex = 51;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.tbSubjectCode);
            this.flowLayoutPanel3.Controls.Add(this.tbDescription);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(820, 48);
            this.flowLayoutPanel3.TabIndex = 1;
            this.flowLayoutPanel3.TabStop = true;
            // 
            // tbSubjectCode
            // 
            this.tbSubjectCode.AnimateReadOnly = true;
            this.tbSubjectCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSubjectCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSubjectCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbSubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSubjectCode.Depth = 0;
            this.tbSubjectCode.Enabled = false;
            this.tbSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSubjectCode.HideSelection = true;
            this.tbSubjectCode.Hint = "Subject Code";
            this.tbSubjectCode.LeadingIcon = null;
            this.tbSubjectCode.Location = new System.Drawing.Point(0, 0);
            this.tbSubjectCode.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.tbSubjectCode.MaxLength = 32767;
            this.tbSubjectCode.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSubjectCode.Name = "tbSubjectCode";
            this.tbSubjectCode.PasswordChar = '\0';
            this.tbSubjectCode.PrefixSuffixText = null;
            this.tbSubjectCode.ReadOnly = false;
            this.tbSubjectCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSubjectCode.SelectedText = "";
            this.tbSubjectCode.SelectionLength = 0;
            this.tbSubjectCode.SelectionStart = 0;
            this.tbSubjectCode.ShortcutsEnabled = true;
            this.tbSubjectCode.Size = new System.Drawing.Size(240, 48);
            this.tbSubjectCode.TabIndex = 43;
            this.tbSubjectCode.TabStop = false;
            this.tbSubjectCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSubjectCode.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.book_tb;
            this.tbSubjectCode.UseSystemPasswordChar = false;
            // 
            // tbDescription
            // 
            this.tbDescription.AnimateReadOnly = false;
            this.tbDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDescription.Depth = 0;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDescription.HideSelection = true;
            this.tbDescription.Hint = "Description";
            this.tbDescription.LeadingIcon = null;
            this.tbDescription.Location = new System.Drawing.Point(290, 0);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(0);
            this.tbDescription.MaxLength = 32767;
            this.tbDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.PrefixSuffixText = null;
            this.tbDescription.ReadOnly = false;
            this.tbDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.ShortcutsEnabled = true;
            this.tbDescription.Size = new System.Drawing.Size(530, 48);
            this.tbDescription.TabIndex = 42;
            this.tbDescription.TabStop = false;
            this.tbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDescription.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.info;
            this.tbDescription.UseSystemPasswordChar = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.numUnits);
            this.flowLayoutPanel4.Controls.Add(this.cboOffering);
            this.flowLayoutPanel4.Controls.Add(this.cboCategory);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 78);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(820, 49);
            this.flowLayoutPanel4.TabIndex = 44;
            this.flowLayoutPanel4.TabStop = true;
            // 
            // numUnits
            // 
            this.numUnits.BackColor = System.Drawing.Color.Transparent;
            this.numUnits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUnits.Location = new System.Drawing.Point(0, 0);
            this.numUnits.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.numUnits.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUnits.Name = "numUnits";
            this.numUnits.Size = new System.Drawing.Size(240, 49);
            this.numUnits.TabIndex = 51;
            this.numUnits.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.numUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboOffering
            // 
            this.cboOffering.AutoResize = false;
            this.cboOffering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboOffering.Depth = 0;
            this.cboOffering.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboOffering.DropDownHeight = 174;
            this.cboOffering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOffering.DropDownWidth = 121;
            this.cboOffering.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboOffering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboOffering.FormattingEnabled = true;
            this.cboOffering.Hint = "Offering";
            this.cboOffering.IntegralHeight = false;
            this.cboOffering.ItemHeight = 43;
            this.cboOffering.Items.AddRange(new object[] {
            "1 - first sem",
            "2 - second sem"});
            this.cboOffering.Location = new System.Drawing.Point(290, 0);
            this.cboOffering.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.cboOffering.MaxDropDownItems = 4;
            this.cboOffering.MouseState = MaterialSkin.MouseState.OUT;
            this.cboOffering.Name = "cboOffering";
            this.cboOffering.Size = new System.Drawing.Size(240, 49);
            this.cboOffering.StartIndex = -1;
            this.cboOffering.TabIndex = 52;
            // 
            // cboCategory
            // 
            this.cboCategory.AutoResize = false;
            this.cboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCategory.Depth = 0;
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCategory.DropDownHeight = 174;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.DropDownWidth = 121;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Hint = "Category";
            this.cboCategory.IntegralHeight = false;
            this.cboCategory.ItemHeight = 43;
            this.cboCategory.Items.AddRange(new object[] {
            "LEC",
            "LAB"});
            this.cboCategory.Location = new System.Drawing.Point(580, 0);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(0);
            this.cboCategory.MaxDropDownItems = 4;
            this.cboCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(240, 49);
            this.cboCategory.StartIndex = -1;
            this.cboCategory.TabIndex = 50;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 157);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel6.TabIndex = 48;
            this.flowLayoutPanel6.TabStop = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.cboStatus);
            this.flowLayoutPanel7.Controls.Add(this.cboCourseCode);
            this.flowLayoutPanel7.Controls.Add(this.tbCurriculumCode);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 157);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(820, 49);
            this.flowLayoutPanel7.TabIndex = 50;
            this.flowLayoutPanel7.TabStop = true;
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
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Hint = "Status";
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.ItemHeight = 43;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatus.Location = new System.Drawing.Point(0, 0);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.cboStatus.MaxDropDownItems = 4;
            this.cboStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(240, 49);
            this.cboStatus.StartIndex = -1;
            this.cboStatus.TabIndex = 49;
            // 
            // cboCourseCode
            // 
            this.cboCourseCode.AutoResize = false;
            this.cboCourseCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCourseCode.Depth = 0;
            this.cboCourseCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCourseCode.DropDownHeight = 174;
            this.cboCourseCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseCode.DropDownWidth = 121;
            this.cboCourseCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboCourseCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCourseCode.FormattingEnabled = true;
            this.cboCourseCode.Hint = "Course Code";
            this.cboCourseCode.IntegralHeight = false;
            this.cboCourseCode.ItemHeight = 43;
            this.cboCourseCode.Items.AddRange(new object[] {
            "BSIT",
            "BSIS"});
            this.cboCourseCode.Location = new System.Drawing.Point(290, 0);
            this.cboCourseCode.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.cboCourseCode.MaxDropDownItems = 4;
            this.cboCourseCode.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCourseCode.Name = "cboCourseCode";
            this.cboCourseCode.Size = new System.Drawing.Size(240, 49);
            this.cboCourseCode.StartIndex = -1;
            this.cboCourseCode.TabIndex = 48;
            // 
            // tbCurriculumCode
            // 
            this.tbCurriculumCode.AnimateReadOnly = false;
            this.tbCurriculumCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCurriculumCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCurriculumCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCurriculumCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCurriculumCode.Depth = 0;
            this.tbCurriculumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCurriculumCode.HideSelection = true;
            this.tbCurriculumCode.Hint = "Curriculum Code";
            this.tbCurriculumCode.LeadingIcon = null;
            this.tbCurriculumCode.Location = new System.Drawing.Point(580, 0);
            this.tbCurriculumCode.Margin = new System.Windows.Forms.Padding(0);
            this.tbCurriculumCode.MaxLength = 32767;
            this.tbCurriculumCode.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCurriculumCode.Name = "tbCurriculumCode";
            this.tbCurriculumCode.PasswordChar = '\0';
            this.tbCurriculumCode.PrefixSuffixText = null;
            this.tbCurriculumCode.ReadOnly = false;
            this.tbCurriculumCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCurriculumCode.SelectedText = "";
            this.tbCurriculumCode.SelectionLength = 0;
            this.tbCurriculumCode.SelectionStart = 0;
            this.tbCurriculumCode.ShortcutsEnabled = true;
            this.tbCurriculumCode.Size = new System.Drawing.Size(240, 48);
            this.tbCurriculumCode.TabIndex = 45;
            this.tbCurriculumCode.TabStop = false;
            this.tbCurriculumCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCurriculumCode.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.calendar;
            this.tbCurriculumCode.UseSystemPasswordChar = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(676, 545);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 36);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(97, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 36);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(37, 26);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(230, 41);
            this.materialLabel3.TabIndex = 42;
            this.materialLabel3.Text = "Subject Update";
            // 
            // SubjectEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Name = "SubjectEdit";
            this.Size = new System.Drawing.Size(994, 676);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialTextBox2 tbSubjectCode;
        private MaterialSkin.Controls.MaterialTextBox2 tbDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUnits;
        private MaterialSkin.Controls.MaterialComboBox cboOffering;
        private MaterialSkin.Controls.MaterialComboBox cboCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private MaterialSkin.Controls.MaterialComboBox cboStatus;
        private MaterialSkin.Controls.MaterialComboBox cboCourseCode;
        private MaterialSkin.Controls.MaterialTextBox2 tbCurriculumCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
