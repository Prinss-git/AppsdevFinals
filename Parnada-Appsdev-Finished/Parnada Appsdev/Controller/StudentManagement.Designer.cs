namespace Parnada_Appsdev.Controller
{
    partial class StudentManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.enrollmentImgList = new System.Windows.Forms.ImageList(this.components);
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStudentDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnStudentEdit = new MaterialSkin.Controls.MaterialButton();
            this.btnStudentAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enrollmentImgList
            // 
            this.enrollmentImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.enrollmentImgList.ImageSize = new System.Drawing.Size(16, 16);
            this.enrollmentImgList.TransparentColor = System.Drawing.Color.Transparent;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnStudentDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnStudentEdit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(620, 102);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 32);
            this.flowLayoutPanel1.TabIndex = 15;
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
            this.btnStudentDelete.Location = new System.Drawing.Point(155, 0);
            this.btnStudentDelete.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStudentDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStudentDelete.Size = new System.Drawing.Size(135, 32);
            this.btnStudentDelete.TabIndex = 15;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnStudentDelete.UseAccentColor = false;
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.studentDelete_Click);
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.AutoSize = false;
            this.btnStudentEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnStudentEdit.Depth = 0;
            this.btnStudentEdit.DrawShadows = false;
            this.btnStudentEdit.HighEmphasis = false;
            this.btnStudentEdit.Icon = global::Parnada_Appsdev.Properties.Resources.edit_user;
            this.btnStudentEdit.Location = new System.Drawing.Point(0, 0);
            this.btnStudentEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnStudentEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStudentEdit.Size = new System.Drawing.Size(135, 32);
            this.btnStudentEdit.TabIndex = 16;
            this.btnStudentEdit.Text = "Edit";
            this.btnStudentEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnStudentEdit.UseAccentColor = false;
            this.btnStudentEdit.UseVisualStyleBackColor = true;
            this.btnStudentEdit.Click += new System.EventHandler(this.studentEdit_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.AutoSize = false;
            this.btnStudentAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStudentAdd.Depth = 0;
            this.btnStudentAdd.HighEmphasis = false;
            this.btnStudentAdd.Icon = global::Parnada_Appsdev.Properties.Resources.add_user;
            this.btnStudentAdd.Location = new System.Drawing.Point(40, 98);
            this.btnStudentAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStudentAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStudentAdd.Size = new System.Drawing.Size(135, 36);
            this.btnStudentAdd.TabIndex = 1;
            this.btnStudentAdd.Text = "Add";
            this.btnStudentAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnStudentAdd.UseAccentColor = false;
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.studentAdd_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.dgvStudents);
            this.materialCard1.Controls.Add(this.btnStudentAdd);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(954, 636);
            this.materialCard1.TabIndex = 16;
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
            this.materialLabel3.Size = new System.Drawing.Size(328, 41);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "Student Management";
            // 
            // StudentManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StudentManagement";
            this.Size = new System.Drawing.Size(994, 676);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Students_ControlRemoved);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnStudentAdd;
        private System.Windows.Forms.ImageList enrollmentImgList;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnStudentDelete;
        private MaterialSkin.Controls.MaterialButton btnStudentEdit;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
