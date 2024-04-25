namespace MidProject.Groups
{
    partial class AssignProjects
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridOfGroups = new System.Windows.Forms.DataGridView();
            this.gridOfProjects = new System.Windows.Forms.DataGridView();
            this.btnSelectGroup = new System.Windows.Forms.Button();
            this.btnSelectProject = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSelectAdvisor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOfGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOfProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Projects";
            // 
            // gridOfGroups
            // 
            this.gridOfGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridOfGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOfGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOfGroups.Location = new System.Drawing.Point(24, 128);
            this.gridOfGroups.Name = "gridOfGroups";
            this.gridOfGroups.RowHeadersWidth = 62;
            this.gridOfGroups.RowTemplate.Height = 28;
            this.gridOfGroups.Size = new System.Drawing.Size(490, 372);
            this.gridOfGroups.TabIndex = 1;
            this.gridOfGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOfGroups_CellContentClick);
            // 
            // gridOfProjects
            // 
            this.gridOfProjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridOfProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOfProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOfProjects.Location = new System.Drawing.Point(579, 128);
            this.gridOfProjects.Name = "gridOfProjects";
            this.gridOfProjects.RowHeadersWidth = 62;
            this.gridOfProjects.RowTemplate.Height = 28;
            this.gridOfProjects.Size = new System.Drawing.Size(490, 372);
            this.gridOfProjects.TabIndex = 2;
            this.gridOfProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOfProjects_CellContentClick);
            // 
            // btnSelectGroup
            // 
            this.btnSelectGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectGroup.Location = new System.Drawing.Point(180, 544);
            this.btnSelectGroup.Name = "btnSelectGroup";
            this.btnSelectGroup.Size = new System.Drawing.Size(158, 48);
            this.btnSelectGroup.TabIndex = 3;
            this.btnSelectGroup.Text = "Select Group";
            this.btnSelectGroup.UseVisualStyleBackColor = true;
            this.btnSelectGroup.Click += new System.EventHandler(this.btnSelectGroup_Click);
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectProject.Location = new System.Drawing.Point(754, 544);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(158, 48);
            this.btnSelectProject.TabIndex = 4;
            this.btnSelectProject.Text = "Select Project";
            this.btnSelectProject.UseVisualStyleBackColor = true;
            this.btnSelectProject.Click += new System.EventHandler(this.btnSelectProject_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 677);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 44);
            this.comboBox1.TabIndex = 5;
            // 
            // btnSelectAdvisor
            // 
            this.btnSelectAdvisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectAdvisor.Location = new System.Drawing.Point(447, 677);
            this.btnSelectAdvisor.Name = "btnSelectAdvisor";
            this.btnSelectAdvisor.Size = new System.Drawing.Size(158, 48);
            this.btnSelectAdvisor.TabIndex = 6;
            this.btnSelectAdvisor.Text = "Select Advisor";
            this.btnSelectAdvisor.UseVisualStyleBackColor = true;
            this.btnSelectAdvisor.Click += new System.EventHandler(this.btnSelectAdvisor_Click);
            // 
            // AssignProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelectAdvisor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSelectProject);
            this.Controls.Add(this.btnSelectGroup);
            this.Controls.Add(this.gridOfProjects);
            this.Controls.Add(this.gridOfGroups);
            this.Controls.Add(this.panel1);
            this.Name = "AssignProjects";
            this.Size = new System.Drawing.Size(1346, 832);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOfGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOfProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridOfGroups;
        private System.Windows.Forms.DataGridView gridOfProjects;
        private System.Windows.Forms.Button btnSelectGroup;
        private System.Windows.Forms.Button btnSelectProject;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSelectAdvisor;
    }
}
