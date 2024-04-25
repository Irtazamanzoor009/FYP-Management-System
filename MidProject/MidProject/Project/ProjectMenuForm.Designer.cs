namespace MidProject.Project
{
    partial class ProjectMenuForm
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
            this.ProjectMenuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProjects = new System.Windows.Forms.Button();
            this.btnViewProjects = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnUpdateProjects = new System.Windows.Forms.Button();
            this.ProjectMenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectMenuPanel
            // 
            this.ProjectMenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProjectMenuPanel.Controls.Add(this.panel1);
            this.ProjectMenuPanel.Controls.Add(this.groupBox1);
            this.ProjectMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectMenuPanel.Name = "ProjectMenuPanel";
            this.ProjectMenuPanel.Size = new System.Drawing.Size(1346, 832);
            this.ProjectMenuPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 100);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnAddProjects);
            this.groupBox1.Controls.Add(this.btnViewProjects);
            this.groupBox1.Controls.Add(this.btnDeleteProject);
            this.groupBox1.Controls.Add(this.btnUpdateProjects);
            this.groupBox1.Location = new System.Drawing.Point(376, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 435);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnAddProjects
            // 
            this.btnAddProjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProjects.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProjects.Location = new System.Drawing.Point(320, 97);
            this.btnAddProjects.Name = "btnAddProjects";
            this.btnAddProjects.Size = new System.Drawing.Size(167, 81);
            this.btnAddProjects.TabIndex = 4;
            this.btnAddProjects.Text = "Add Project";
            this.btnAddProjects.UseVisualStyleBackColor = false;
            this.btnAddProjects.Click += new System.EventHandler(this.btnAddProjects_Click);
            // 
            // btnViewProjects
            // 
            this.btnViewProjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewProjects.BackColor = System.Drawing.Color.LightCoral;
            this.btnViewProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProjects.Location = new System.Drawing.Point(84, 97);
            this.btnViewProjects.Name = "btnViewProjects";
            this.btnViewProjects.Size = new System.Drawing.Size(167, 81);
            this.btnViewProjects.TabIndex = 1;
            this.btnViewProjects.Text = "View Projects";
            this.btnViewProjects.UseVisualStyleBackColor = false;
            this.btnViewProjects.Click += new System.EventHandler(this.btnViewProjects_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteProject.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProject.Location = new System.Drawing.Point(84, 235);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(167, 81);
            this.btnDeleteProject.TabIndex = 3;
            this.btnDeleteProject.Text = "Delete Projects";
            this.btnDeleteProject.UseVisualStyleBackColor = false;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnUpdateProjects
            // 
            this.btnUpdateProjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateProjects.BackColor = System.Drawing.Color.LightCoral;
            this.btnUpdateProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProjects.Location = new System.Drawing.Point(320, 235);
            this.btnUpdateProjects.Name = "btnUpdateProjects";
            this.btnUpdateProjects.Size = new System.Drawing.Size(167, 81);
            this.btnUpdateProjects.TabIndex = 2;
            this.btnUpdateProjects.Text = "Update Projects";
            this.btnUpdateProjects.UseVisualStyleBackColor = false;
            this.btnUpdateProjects.Click += new System.EventHandler(this.btnUpdateProjects_Click);
            // 
            // ProjectMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectMenuPanel);
            this.Name = "ProjectMenuForm";
            this.Size = new System.Drawing.Size(1346, 832);
            this.ProjectMenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProjectMenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProjects;
        private System.Windows.Forms.Button btnViewProjects;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnUpdateProjects;
    }
}
