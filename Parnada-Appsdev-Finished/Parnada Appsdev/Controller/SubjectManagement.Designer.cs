namespace Parnada_Appsdev.Controller.EntryControls
{
    partial class SubjectManagement
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
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnSubjectAdd = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubjectDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSubjectEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.flowLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvSubjects);
            this.materialCard1.Controls.Add(this.btnSubjectAdd);
            this.materialCard1.Controls.Add(this.flowLayoutPanel8);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(954, 636);
            this.materialCard1.TabIndex = 39;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AllowUserToResizeColumns = false;
            this.dgvSubjects.AllowUserToResizeRows = false;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSubjects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubjects.EnableHeadersVisualStyles = false;
            this.dgvSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvSubjects.Location = new System.Drawing.Point(40, 204);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(870, 393);
            this.dgvSubjects.TabIndex = 51;
            // 
            // btnSubjectAdd
            // 
            this.btnSubjectAdd.AutoSize = false;
            this.btnSubjectAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubjectAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubjectAdd.Depth = 0;
            this.btnSubjectAdd.HighEmphasis = false;
            this.btnSubjectAdd.Icon = global::Parnada_Appsdev.Properties.Resources.add_user;
            this.btnSubjectAdd.Location = new System.Drawing.Point(40, 98);
            this.btnSubjectAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubjectAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubjectAdd.Name = "btnSubjectAdd";
            this.btnSubjectAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubjectAdd.Size = new System.Drawing.Size(135, 36);
            this.btnSubjectAdd.TabIndex = 49;
            this.btnSubjectAdd.Text = "Add";
            this.btnSubjectAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubjectAdd.UseAccentColor = false;
            this.btnSubjectAdd.UseVisualStyleBackColor = true;
            this.btnSubjectAdd.Click += new System.EventHandler(this.subjectAdd_Click);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.btnSubjectDelete);
            this.flowLayoutPanel8.Controls.Add(this.btnSubjectEdit);
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(620, 102);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(290, 32);
            this.flowLayoutPanel8.TabIndex = 50;
            // 
            // btnSubjectDelete
            // 
            this.btnSubjectDelete.AutoSize = false;
            this.btnSubjectDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubjectDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnSubjectDelete.Depth = 0;
            this.btnSubjectDelete.DrawShadows = false;
            this.btnSubjectDelete.HighEmphasis = false;
            this.btnSubjectDelete.Icon = global::Parnada_Appsdev.Properties.Resources.remove_user;
            this.btnSubjectDelete.Location = new System.Drawing.Point(155, 0);
            this.btnSubjectDelete.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSubjectDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubjectDelete.Name = "btnSubjectDelete";
            this.btnSubjectDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubjectDelete.Size = new System.Drawing.Size(135, 32);
            this.btnSubjectDelete.TabIndex = 15;
            this.btnSubjectDelete.Text = "Delete";
            this.btnSubjectDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubjectDelete.UseAccentColor = false;
            this.btnSubjectDelete.UseVisualStyleBackColor = true;
            this.btnSubjectDelete.Click += new System.EventHandler(this.subjectDelete_Click);
            // 
            // btnSubjectEdit
            // 
            this.btnSubjectEdit.AutoSize = false;
            this.btnSubjectEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubjectEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnSubjectEdit.Depth = 0;
            this.btnSubjectEdit.DrawShadows = false;
            this.btnSubjectEdit.HighEmphasis = false;
            this.btnSubjectEdit.Icon = global::Parnada_Appsdev.Properties.Resources.edit_user;
            this.btnSubjectEdit.Location = new System.Drawing.Point(0, 0);
            this.btnSubjectEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubjectEdit.Name = "btnSubjectEdit";
            this.btnSubjectEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubjectEdit.Size = new System.Drawing.Size(135, 32);
            this.btnSubjectEdit.TabIndex = 16;
            this.btnSubjectEdit.Text = "Edit";
            this.btnSubjectEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubjectEdit.UseAccentColor = false;
            this.btnSubjectEdit.UseVisualStyleBackColor = true;
            this.btnSubjectEdit.Click += new System.EventHandler(this.subjectEdit_Click);
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
            this.materialLabel3.Size = new System.Drawing.Size(324, 41);
            this.materialLabel3.TabIndex = 42;
            this.materialLabel3.Text = "Subject Management";
            // 
            // SubjectManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SubjectManagement";
            this.Size = new System.Drawing.Size(994, 676);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.SubjectManagement_ControlRemoved);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnSubjectAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private MaterialSkin.Controls.MaterialButton btnSubjectDelete;
        private MaterialSkin.Controls.MaterialButton btnSubjectEdit;
        private System.Windows.Forms.DataGridView dgvSubjects;
    }
}
