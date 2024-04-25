namespace MidProject.Reports
{
    partial class ReportMenuForm
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
            this.btnNonGroupStudents = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewAssignedProjects = new System.Windows.Forms.Button();
            this.btnAllAdvisors = new System.Windows.Forms.Button();
            this.btnAllStudents = new System.Windows.Forms.Button();
            this.btnEvaluationMarks = new System.Windows.Forms.Button();
            this.btnNonGroupStudents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNonGroupStudents
            // 
            this.btnNonGroupStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNonGroupStudents.Controls.Add(this.panel1);
            this.btnNonGroupStudents.Controls.Add(this.groupBox1);
            this.btnNonGroupStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNonGroupStudents.Location = new System.Drawing.Point(0, 0);
            this.btnNonGroupStudents.Name = "btnNonGroupStudents";
            this.btnNonGroupStudents.Size = new System.Drawing.Size(1346, 832);
            this.btnNonGroupStudents.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(437, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Download Reports";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnEvaluationMarks);
            this.groupBox1.Controls.Add(this.btnViewAssignedProjects);
            this.groupBox1.Controls.Add(this.btnAllAdvisors);
            this.groupBox1.Controls.Add(this.btnAllStudents);
            this.groupBox1.Location = new System.Drawing.Point(376, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 551);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnViewAssignedProjects
            // 
            this.btnViewAssignedProjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAssignedProjects.BackColor = System.Drawing.Color.LightCoral;
            this.btnViewAssignedProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAssignedProjects.Location = new System.Drawing.Point(82, 194);
            this.btnViewAssignedProjects.Name = "btnViewAssignedProjects";
            this.btnViewAssignedProjects.Size = new System.Drawing.Size(167, 114);
            this.btnViewAssignedProjects.TabIndex = 6;
            this.btnViewAssignedProjects.Text = "View Assigned Projects";
            this.btnViewAssignedProjects.UseVisualStyleBackColor = false;
            this.btnViewAssignedProjects.Click += new System.EventHandler(this.btnViewAssignedProjects_Click);
            // 
            // btnAllAdvisors
            // 
            this.btnAllAdvisors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllAdvisors.BackColor = System.Drawing.Color.LightCoral;
            this.btnAllAdvisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllAdvisors.Location = new System.Drawing.Point(318, 60);
            this.btnAllAdvisors.Name = "btnAllAdvisors";
            this.btnAllAdvisors.Size = new System.Drawing.Size(167, 81);
            this.btnAllAdvisors.TabIndex = 4;
            this.btnAllAdvisors.Text = "All Advisors";
            this.btnAllAdvisors.UseVisualStyleBackColor = false;
            this.btnAllAdvisors.Click += new System.EventHandler(this.btnAllAdvisors_Click);
            // 
            // btnAllStudents
            // 
            this.btnAllStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllStudents.BackColor = System.Drawing.Color.LightCoral;
            this.btnAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudents.Location = new System.Drawing.Point(82, 60);
            this.btnAllStudents.Name = "btnAllStudents";
            this.btnAllStudents.Size = new System.Drawing.Size(167, 81);
            this.btnAllStudents.TabIndex = 1;
            this.btnAllStudents.Text = "All Students";
            this.btnAllStudents.UseVisualStyleBackColor = false;
            this.btnAllStudents.Click += new System.EventHandler(this.btnAllStudents_Click);
            // 
            // btnEvaluationMarks
            // 
            this.btnEvaluationMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEvaluationMarks.BackColor = System.Drawing.Color.LightCoral;
            this.btnEvaluationMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluationMarks.Location = new System.Drawing.Point(318, 194);
            this.btnEvaluationMarks.Name = "btnEvaluationMarks";
            this.btnEvaluationMarks.Size = new System.Drawing.Size(167, 114);
            this.btnEvaluationMarks.TabIndex = 7;
            this.btnEvaluationMarks.Text = "Evaluation Marks";
            this.btnEvaluationMarks.UseVisualStyleBackColor = false;
            this.btnEvaluationMarks.Click += new System.EventHandler(this.btnEvaluationMarks_Click);
            // 
            // ReportMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNonGroupStudents);
            this.Name = "ReportMenuForm";
            this.Size = new System.Drawing.Size(1346, 832);
            this.btnNonGroupStudents.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnNonGroupStudents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAllAdvisors;
        private System.Windows.Forms.Button btnAllStudents;
        private System.Windows.Forms.Button btnViewAssignedProjects;
        private System.Windows.Forms.Button btnEvaluationMarks;
    }
}
