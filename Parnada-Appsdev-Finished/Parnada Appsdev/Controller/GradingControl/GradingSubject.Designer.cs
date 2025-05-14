namespace Parnada_Appsdev.Controller.GradingControl
{
    partial class GradingSubject
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.tbSubjectCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbGrade = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbRemarks = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.flowLayoutPanel2);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 20);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(310, 360);
            this.materialCard1.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.tbSubjectCode);
            this.flowLayoutPanel2.Controls.Add(this.tbGrade);
            this.flowLayoutPanel2.Controls.Add(this.tbRemarks);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(36, 76);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(240, 184);
            this.flowLayoutPanel2.TabIndex = 56;
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
            this.materialLabel3.TabIndex = 55;
            this.materialLabel3.Text = "Subject Pre-Requisite Entry";
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
            this.flowLayoutPanel1.TabIndex = 48;
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
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            this.tbSubjectCode.TabIndex = 50;
            this.tbSubjectCode.TabStop = false;
            this.tbSubjectCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSubjectCode.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.circle_check;
            this.tbSubjectCode.UseSystemPasswordChar = false;
            // 
            // tbGrade
            // 
            this.tbGrade.AnimateReadOnly = false;
            this.tbGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGrade.Depth = 0;
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGrade.HideSelection = true;
            this.tbGrade.Hint = "Grade";
            this.tbGrade.LeadingIcon = null;
            this.tbGrade.Location = new System.Drawing.Point(0, 68);
            this.tbGrade.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tbGrade.MaxLength = 32767;
            this.tbGrade.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.PasswordChar = '\0';
            this.tbGrade.PrefixSuffixText = null;
            this.tbGrade.ReadOnly = false;
            this.tbGrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGrade.SelectedText = "";
            this.tbGrade.SelectionLength = 0;
            this.tbGrade.SelectionStart = 0;
            this.tbGrade.ShortcutsEnabled = true;
            this.tbGrade.Size = new System.Drawing.Size(240, 48);
            this.tbGrade.TabIndex = 48;
            this.tbGrade.TabStop = false;
            this.tbGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGrade.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.grade;
            this.tbGrade.UseSystemPasswordChar = false;
            this.tbGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrade_KeyPress);
            this.tbGrade.TextChanged += new System.EventHandler(this.tbGrade_TextChanged);
            // 
            // tbRemarks
            // 
            this.tbRemarks.AnimateReadOnly = true;
            this.tbRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbRemarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbRemarks.Depth = 0;
            this.tbRemarks.Enabled = false;
            this.tbRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbRemarks.HideSelection = true;
            this.tbRemarks.Hint = "Remarks";
            this.tbRemarks.LeadingIcon = null;
            this.tbRemarks.Location = new System.Drawing.Point(0, 136);
            this.tbRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.tbRemarks.MaxLength = 32767;
            this.tbRemarks.MouseState = MaterialSkin.MouseState.OUT;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.PasswordChar = '\0';
            this.tbRemarks.PrefixSuffixText = null;
            this.tbRemarks.ReadOnly = false;
            this.tbRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbRemarks.SelectedText = "";
            this.tbRemarks.SelectionLength = 0;
            this.tbRemarks.SelectionStart = 0;
            this.tbRemarks.ShortcutsEnabled = true;
            this.tbRemarks.Size = new System.Drawing.Size(240, 48);
            this.tbRemarks.TabIndex = 49;
            this.tbRemarks.TabStop = false;
            this.tbRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbRemarks.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.circle_check;
            this.tbRemarks.UseSystemPasswordChar = false;
            // 
            // GradingSubject
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(348, 392);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GradingSubject";
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox2 tbGrade;
        private MaterialSkin.Controls.MaterialTextBox2 tbRemarks;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 tbSubjectCode;
    }
}
