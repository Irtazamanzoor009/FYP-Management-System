namespace MidProject.Evaluations
{
    partial class EvaluationMenu
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
            this.evaluationPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManageEvaluation = new System.Windows.Forms.Button();
            this.btnCreateEvaluation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.evaluationPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // evaluationPanel
            // 
            this.evaluationPanel.Controls.Add(this.panel1);
            this.evaluationPanel.Controls.Add(this.groupBox1);
            this.evaluationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evaluationPanel.Location = new System.Drawing.Point(0, 0);
            this.evaluationPanel.Name = "evaluationPanel";
            this.evaluationPanel.Size = new System.Drawing.Size(1346, 832);
            this.evaluationPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnManageEvaluation);
            this.groupBox1.Controls.Add(this.btnCreateEvaluation);
            this.groupBox1.Location = new System.Drawing.Point(376, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 473);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnManageEvaluation
            // 
            this.btnManageEvaluation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageEvaluation.BackColor = System.Drawing.Color.LightCoral;
            this.btnManageEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEvaluation.Location = new System.Drawing.Point(319, 147);
            this.btnManageEvaluation.Name = "btnManageEvaluation";
            this.btnManageEvaluation.Size = new System.Drawing.Size(167, 81);
            this.btnManageEvaluation.TabIndex = 4;
            this.btnManageEvaluation.Text = "Manage Evaluation";
            this.btnManageEvaluation.UseVisualStyleBackColor = false;
            this.btnManageEvaluation.Click += new System.EventHandler(this.btnManageEvaluation_Click);
            // 
            // btnCreateEvaluation
            // 
            this.btnCreateEvaluation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateEvaluation.BackColor = System.Drawing.Color.LightCoral;
            this.btnCreateEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvaluation.Location = new System.Drawing.Point(83, 147);
            this.btnCreateEvaluation.Name = "btnCreateEvaluation";
            this.btnCreateEvaluation.Size = new System.Drawing.Size(167, 81);
            this.btnCreateEvaluation.TabIndex = 1;
            this.btnCreateEvaluation.Text = "Create Evaluation";
            this.btnCreateEvaluation.UseVisualStyleBackColor = false;
            this.btnCreateEvaluation.Click += new System.EventHandler(this.btnCreateEvaluation_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 100);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evaluation Menu";
            // 
            // EvaluationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.evaluationPanel);
            this.Name = "EvaluationMenu";
            this.Size = new System.Drawing.Size(1346, 832);
            this.evaluationPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel evaluationPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManageEvaluation;
        private System.Windows.Forms.Button btnCreateEvaluation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
