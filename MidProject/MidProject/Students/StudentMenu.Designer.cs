namespace MidProject.Students
{
    partial class StudentMenuForm
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
            this.StudentMenuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudents = new System.Windows.Forms.Button();
            this.btnUpdateStudents = new System.Windows.Forms.Button();
            this.StudentMenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentMenuPanel
            // 
            this.StudentMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(201)))), ((int)(((byte)(242)))));
            this.StudentMenuPanel.Controls.Add(this.panel1);
            this.StudentMenuPanel.Controls.Add(this.groupBox1);
            this.StudentMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.StudentMenuPanel.Name = "StudentMenuPanel";
            this.StudentMenuPanel.Size = new System.Drawing.Size(1121, 693);
            this.StudentMenuPanel.TabIndex = 0;
            this.StudentMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentMenuPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 100);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.btnViewStudent);
            this.groupBox1.Controls.Add(this.btnDeleteStudents);
            this.groupBox1.Controls.Add(this.btnUpdateStudents);
            this.groupBox1.Location = new System.Drawing.Point(263, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 435);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(149)))), ((int)(((byte)(246)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(320, 97);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(167, 81);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click_1);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(149)))), ((int)(((byte)(246)))));
            this.btnViewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudent.Location = new System.Drawing.Point(84, 97);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(167, 81);
            this.btnViewStudent.TabIndex = 1;
            this.btnViewStudent.Text = "View Students";
            this.btnViewStudent.UseVisualStyleBackColor = false;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnDeleteStudents
            // 
            this.btnDeleteStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(149)))), ((int)(((byte)(246)))));
            this.btnDeleteStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudents.Location = new System.Drawing.Point(84, 235);
            this.btnDeleteStudents.Name = "btnDeleteStudents";
            this.btnDeleteStudents.Size = new System.Drawing.Size(167, 81);
            this.btnDeleteStudents.TabIndex = 3;
            this.btnDeleteStudents.Text = "Delete Student";
            this.btnDeleteStudents.UseVisualStyleBackColor = false;
            this.btnDeleteStudents.Click += new System.EventHandler(this.btnDeleteStudents_Click);
            // 
            // btnUpdateStudents
            // 
            this.btnUpdateStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(149)))), ((int)(((byte)(246)))));
            this.btnUpdateStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudents.Location = new System.Drawing.Point(320, 235);
            this.btnUpdateStudents.Name = "btnUpdateStudents";
            this.btnUpdateStudents.Size = new System.Drawing.Size(167, 81);
            this.btnUpdateStudents.TabIndex = 2;
            this.btnUpdateStudents.Text = "Update Students";
            this.btnUpdateStudents.UseVisualStyleBackColor = false;
            this.btnUpdateStudents.Click += new System.EventHandler(this.btnUpdateStudents_Click);
            // 
            // StudentMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.StudentMenuPanel);
            this.Name = "StudentMenuForm";
            this.Size = new System.Drawing.Size(1121, 693);
            this.StudentMenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StudentMenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.Button btnDeleteStudents;
        private System.Windows.Forms.Button btnUpdateStudents;
    }
}
