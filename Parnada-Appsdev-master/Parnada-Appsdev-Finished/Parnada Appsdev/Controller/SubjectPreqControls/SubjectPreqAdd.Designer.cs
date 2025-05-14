namespace Parnada_Appsdev.Controller.SubjectPreqControls
{
    partial class SubjectPreqAdd
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSubjectCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbSubjectPreqCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboSubjectCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.flowLayoutPanel2);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 20);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(310, 360);
            this.materialCard1.TabIndex = 40;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.tbSubjectCode);
            this.flowLayoutPanel2.Controls.Add(this.tbSubjectPreqCode);
            this.flowLayoutPanel2.Controls.Add(this.cboSubjectCategory);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(36, 76);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(240, 185);
            this.flowLayoutPanel2.TabIndex = 54;
            // 
            // tbSubjectCode
            // 
            this.tbSubjectCode.AnimateReadOnly = false;
            this.tbSubjectCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSubjectCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSubjectCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbSubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSubjectCode.Depth = 0;
            this.tbSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSubjectCode.HideSelection = true;
            this.tbSubjectCode.Hint = "Subject Code";
            this.tbSubjectCode.LeadingIcon = null;
            this.tbSubjectCode.Location = new System.Drawing.Point(0, 0);
            this.tbSubjectCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
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
            this.tbSubjectCode.TabIndex = 48;
            this.tbSubjectCode.TabStop = false;
            this.tbSubjectCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSubjectCode.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.book_tb;
            this.tbSubjectCode.UseSystemPasswordChar = false;
            // 
            // tbSubjectPreqCode
            // 
            this.tbSubjectPreqCode.AnimateReadOnly = false;
            this.tbSubjectPreqCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSubjectPreqCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSubjectPreqCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbSubjectPreqCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSubjectPreqCode.Depth = 0;
            this.tbSubjectPreqCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSubjectPreqCode.HideSelection = true;
            this.tbSubjectPreqCode.Hint = "Subject Pre-Requisite Code";
            this.tbSubjectPreqCode.LeadingIcon = null;
            this.tbSubjectPreqCode.Location = new System.Drawing.Point(0, 68);
            this.tbSubjectPreqCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tbSubjectPreqCode.MaxLength = 32767;
            this.tbSubjectPreqCode.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSubjectPreqCode.Name = "tbSubjectPreqCode";
            this.tbSubjectPreqCode.PasswordChar = '\0';
            this.tbSubjectPreqCode.PrefixSuffixText = null;
            this.tbSubjectPreqCode.ReadOnly = false;
            this.tbSubjectPreqCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSubjectPreqCode.SelectedText = "";
            this.tbSubjectPreqCode.SelectionLength = 0;
            this.tbSubjectPreqCode.SelectionStart = 0;
            this.tbSubjectPreqCode.ShortcutsEnabled = true;
            this.tbSubjectPreqCode.Size = new System.Drawing.Size(240, 48);
            this.tbSubjectPreqCode.TabIndex = 49;
            this.tbSubjectPreqCode.TabStop = false;
            this.tbSubjectPreqCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSubjectPreqCode.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.book_tb;
            this.tbSubjectPreqCode.UseSystemPasswordChar = false;
            // 
            // cboSubjectCategory
            // 
            this.cboSubjectCategory.AutoResize = false;
            this.cboSubjectCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSubjectCategory.Depth = 0;
            this.cboSubjectCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSubjectCategory.DropDownHeight = 174;
            this.cboSubjectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubjectCategory.DropDownWidth = 121;
            this.cboSubjectCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboSubjectCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboSubjectCategory.FormattingEnabled = true;
            this.cboSubjectCategory.Hint = "Subject Category";
            this.cboSubjectCategory.IntegralHeight = false;
            this.cboSubjectCategory.ItemHeight = 43;
            this.cboSubjectCategory.Items.AddRange(new object[] {
            "Co-Requisite",
            "Pre-Requisite"});
            this.cboSubjectCategory.Location = new System.Drawing.Point(0, 136);
            this.cboSubjectCategory.Margin = new System.Windows.Forms.Padding(0);
            this.cboSubjectCategory.MaxDropDownItems = 4;
            this.cboSubjectCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cboSubjectCategory.Name = "cboSubjectCategory";
            this.cboSubjectCategory.Size = new System.Drawing.Size(240, 49);
            this.cboSubjectCategory.StartIndex = -1;
            this.cboSubjectCategory.TabIndex = 53;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(61, 298);
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
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(30, 25);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(245, 24);
            this.materialLabel3.TabIndex = 42;
            this.materialLabel3.Text = "Subject Pre-Requisite Entry";
            // 
            // SubjectPreqAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(348, 392);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SubjectPreqAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 tbSubjectCode;
        private MaterialSkin.Controls.MaterialTextBox2 tbSubjectPreqCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialComboBox cboSubjectCategory;
    }
}
