namespace UniversityApp
{
    partial class UniversityManagementSystemForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentEntryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.courseEntryButton = new System.Windows.Forms.Button();
            this.studentEntryButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentEntryButton
            // 
            this.departmentEntryButton.Location = new System.Drawing.Point(52, 54);
            this.departmentEntryButton.Name = "departmentEntryButton";
            this.departmentEntryButton.Size = new System.Drawing.Size(135, 43);
            this.departmentEntryButton.TabIndex = 0;
            this.departmentEntryButton.Text = "Department Entry";
            this.departmentEntryButton.UseVisualStyleBackColor = true;
            this.departmentEntryButton.Click += new System.EventHandler(this.departmentEntryButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.courseEntryButton);
            this.groupBox1.Controls.Add(this.studentEntryButton);
            this.groupBox1.Controls.Add(this.departmentEntryButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "University Management System";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "Enrollment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.enrollmnetButton_Click);
            // 
            // courseEntryButton
            // 
            this.courseEntryButton.Location = new System.Drawing.Point(52, 121);
            this.courseEntryButton.Name = "courseEntryButton";
            this.courseEntryButton.Size = new System.Drawing.Size(135, 43);
            this.courseEntryButton.TabIndex = 0;
            this.courseEntryButton.Text = "Course Entry";
            this.courseEntryButton.UseVisualStyleBackColor = true;
            this.courseEntryButton.Click += new System.EventHandler(this.courseEntryButton_Click);
            // 
            // studentEntryButton
            // 
            this.studentEntryButton.Location = new System.Drawing.Point(216, 54);
            this.studentEntryButton.Name = "studentEntryButton";
            this.studentEntryButton.Size = new System.Drawing.Size(135, 43);
            this.studentEntryButton.TabIndex = 0;
            this.studentEntryButton.Text = "Student Entry";
            this.studentEntryButton.UseVisualStyleBackColor = true;
            this.studentEntryButton.Click += new System.EventHandler(this.studentEntryButton_Click);
            // 
            // UniversityManagementSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 227);
            this.Controls.Add(this.groupBox1);
            this.Name = "UniversityManagementSystemForm";
            this.Text = "University Management System";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button departmentEntryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button courseEntryButton;
        private System.Windows.Forms.Button studentEntryButton;
    }
}

