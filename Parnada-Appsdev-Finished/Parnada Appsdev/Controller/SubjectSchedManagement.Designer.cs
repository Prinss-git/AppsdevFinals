namespace Parnada_Appsdev.Controller
{
    partial class SubjectSchedManagement
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
            this.btnSubjectSchedDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSubjectSchedEdit = new MaterialSkin.Controls.MaterialButton();
            this.dgvSubjectSched = new System.Windows.Forms.DataGridView();
            this.btnSubjectSchedAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectSched)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.dgvSubjectSched);
            this.materialCard1.Controls.Add(this.btnSubjectSchedAdd);
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
            this.materialLabel3.Size = new System.Drawing.Size(471, 41);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "Subject Schedule Management";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSubjectSchedDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSubjectSchedEdit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(620, 102);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 32);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnSubjectSchedDelete
            // 
            this.btnSubjectSchedDelete.AutoSize = false;
            this.btnSubjectSchedDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubjectSchedDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnSubjectSchedDelete.Depth = 0;
            this.btnSubjectSchedDelete.DrawShadows = false;
            this.btnSubjectSchedDelete.HighEmphasis = false;
            this.btnSubjectSchedDelete.Icon = global::Parnada_Appsdev.Properties.Resources.remove_user;
            this.btnSubjectSchedDelete.Location = new System.Drawing.Point(155, 0);
            this.btnSubjectSchedDelete.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubjectSchedDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubjectSchedDelete.Name = "btnSubjectSchedDelete";
            this.btnSubjectSchedDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubjectSchedDelete.Size = new System.Drawing.Size(135, 32);
            this.btnSubjectSchedDelete.TabIndex = 15;
            this.btnSubjectSchedDelete.Text = "Delete";
            this.btnSubjectSchedDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubjectSchedDelete.UseAccentColor = false;
            this.btnSubjectSchedDelete.UseVisualStyleBackColor = true;
            this.btnSubjectSchedDelete.Click += new System.EventHandler(this.btnSubjectSchedDelete_Click);
            // 
            // btnSubjectSchedEdit
            // 
            this.btnSubjectSchedEdit.AutoSize = false;
            this.btnSubjectSchedEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubjectSchedEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnSubjectSchedEdit.Depth = 0;
            this.btnSubjectSchedEdit.DrawShadows = false;
            this.btnSubjectSchedEdit.HighEmphasis = false;
            this.btnSubjectSchedEdit.Icon = global::Parnada_Appsdev.Properties.Resources.edit_user;
            this.btnSubjectSchedEdit.Location = new System.Drawing.Point(0, 0);
            this.btnSubjectSchedEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectSchedEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubjectSchedEdit.Name = "btnSubjectSchedEdit";
            this.btnSubjectSchedEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubjectSchedEdit.Size = new System.Drawing.Size(135, 32);
            this.btnSubjectSchedEdit.TabIndex = 16;
            this.btnSubjectSchedEdit.Text = "Edit";
            this.btnSubjectSchedEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubjectSchedEdit.UseAccentColor = false;
            this.btnSubjectSchedEdit.UseVisualStyleBackColor = true;
            this.btnSubjectSchedEdit.Click += new System.EventHandler(this.btnSubjectSchedEdit_Click);
            // 
            // dgvSubjectSched
            // 
            this.dgvSubjectSched.AllowUserToAddRows = false;
            this.dgvSubjectSched.AllowUserToDeleteRows = false;
            this.dgvSubjectSched.AllowUserToResizeColumns = false;
            this.dgvSubjectSched.AllowUserToResizeRows = false;
            this.dgvSubjectSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSubjectSched.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSubjectSched.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjectSched.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjectSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjectSched.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubjectSched.EnableHeadersVisualStyles = false;
            this.dgvSubjectSched.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvSubjectSched.Location = new System.Drawing.Point(40, 204);
            this.dgvSubjectSched.MultiSelect = false;
            this.dgvSubjectSched.Name = "dgvSubjectSched";
            this.dgvSubjectSched.ReadOnly = true;
            this.dgvSubjectSched.RowHeadersVisible = false;
            this.dgvSubjectSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjectSched.Size = new System.Drawing.Size(870, 393);
            this.dgvSubjectSched.TabIndex = 12;
            // 
            // btnSubjectSchedAdd
            // 
            this.btnSubjectSchedAdd.AutoSize = false;
            this.btnSubjectSchedAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubjectSchedAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubjectSchedAdd.Depth = 0;
            this.btnSubjectSchedAdd.HighEmphasis = false;
            this.btnSubjectSchedAdd.Icon = global::Parnada_Appsdev.Properties.Resources.add_user;
            this.btnSubjectSchedAdd.Location = new System.Drawing.Point(40, 98);
            this.btnSubjectSchedAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubjectSchedAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubjectSchedAdd.Name = "btnSubjectSchedAdd";
            this.btnSubjectSchedAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubjectSchedAdd.Size = new System.Drawing.Size(135, 36);
            this.btnSubjectSchedAdd.TabIndex = 1;
            this.btnSubjectSchedAdd.Text = "Add";
            this.btnSubjectSchedAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubjectSchedAdd.UseAccentColor = false;
            this.btnSubjectSchedAdd.UseVisualStyleBackColor = true;
            this.btnSubjectSchedAdd.Click += new System.EventHandler(this.btnSubjectSchedAdd_Click);
            // 
            // SubjectSchedManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SubjectSchedManagement";
            this.Size = new System.Drawing.Size(994, 676);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.SubjectSchedManagement_ControlRemoved);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectSched)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnSubjectSchedDelete;
        private MaterialSkin.Controls.MaterialButton btnSubjectSchedEdit;
        private System.Windows.Forms.DataGridView dgvSubjectSched;
        private MaterialSkin.Controls.MaterialButton btnSubjectSchedAdd;
    }
}
