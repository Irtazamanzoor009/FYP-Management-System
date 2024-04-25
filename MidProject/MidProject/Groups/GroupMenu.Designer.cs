namespace MidProject.Groups
{
    partial class GroupMenu
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
            this.GroupMenuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManageGroup = new System.Windows.Forms.Button();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.btnAssignProject = new System.Windows.Forms.Button();
            this.btnViewGroups = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupMenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupMenuPanel
            // 
            this.GroupMenuPanel.Controls.Add(this.panel1);
            this.GroupMenuPanel.Controls.Add(this.groupBox1);
            this.GroupMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupMenuPanel.Name = "GroupMenuPanel";
            this.GroupMenuPanel.Size = new System.Drawing.Size(1346, 832);
            this.GroupMenuPanel.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(304, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnViewGroups);
            this.groupBox1.Controls.Add(this.btnManageGroup);
            this.groupBox1.Controls.Add(this.btnCreateGroup);
            this.groupBox1.Controls.Add(this.btnAssignProject);
            this.groupBox1.Location = new System.Drawing.Point(376, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 473);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnManageGroup
            // 
            this.btnManageGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageGroup.BackColor = System.Drawing.Color.LightCoral;
            this.btnManageGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageGroup.Location = new System.Drawing.Point(320, 66);
            this.btnManageGroup.Name = "btnManageGroup";
            this.btnManageGroup.Size = new System.Drawing.Size(167, 81);
            this.btnManageGroup.TabIndex = 4;
            this.btnManageGroup.Text = "Manage Group";
            this.btnManageGroup.UseVisualStyleBackColor = false;
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateGroup.BackColor = System.Drawing.Color.LightCoral;
            this.btnCreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGroup.Location = new System.Drawing.Point(84, 66);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(167, 81);
            this.btnCreateGroup.TabIndex = 1;
            this.btnCreateGroup.Text = "Create Group";
            this.btnCreateGroup.UseVisualStyleBackColor = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // btnAssignProject
            // 
            this.btnAssignProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssignProject.BackColor = System.Drawing.Color.LightCoral;
            this.btnAssignProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignProject.Location = new System.Drawing.Point(84, 204);
            this.btnAssignProject.Name = "btnAssignProject";
            this.btnAssignProject.Size = new System.Drawing.Size(167, 81);
            this.btnAssignProject.TabIndex = 3;
            this.btnAssignProject.Text = "Assign Project";
            this.btnAssignProject.UseVisualStyleBackColor = false;
            this.btnAssignProject.Click += new System.EventHandler(this.btnAssignProject_Click);
            // 
            // btnViewGroups
            // 
            this.btnViewGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewGroups.BackColor = System.Drawing.Color.LightCoral;
            this.btnViewGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGroups.Location = new System.Drawing.Point(320, 204);
            this.btnViewGroups.Name = "btnViewGroups";
            this.btnViewGroups.Size = new System.Drawing.Size(167, 81);
            this.btnViewGroups.TabIndex = 5;
            this.btnViewGroups.Text = "View Groups";
            this.btnViewGroups.UseVisualStyleBackColor = false;
            this.btnViewGroups.Click += new System.EventHandler(this.btnViewGroups_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "View Assigned Project";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupMenuPanel);
            this.Name = "GroupMenu";
            this.Size = new System.Drawing.Size(1346, 832);
            this.GroupMenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GroupMenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManageGroup;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.Button btnAssignProject;
        private System.Windows.Forms.Button btnViewGroups;
        private System.Windows.Forms.Button button1;
    }
}
