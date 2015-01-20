namespace UniversityApp
{
    partial class CourseEntryUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.courseTitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseCreditTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseCodeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.courseTitleTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.courseCreditTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.courseCodeTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(251, 179);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(129, 152);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(197, 21);
            this.departmentComboBox.TabIndex = 2;
            // 
            // courseTitleTextBox
            // 
            this.courseTitleTextBox.Location = new System.Drawing.Point(129, 68);
            this.courseTitleTextBox.Name = "courseTitleTextBox";
            this.courseTitleTextBox.Size = new System.Drawing.Size(197, 20);
            this.courseTitleTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course Title";
            // 
            // courseCreditTextBox
            // 
            this.courseCreditTextBox.Location = new System.Drawing.Point(129, 107);
            this.courseCreditTextBox.Name = "courseCreditTextBox";
            this.courseCreditTextBox.Size = new System.Drawing.Size(197, 20);
            this.courseCreditTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Credit";
            // 
            // courseCodeTextBox
            // 
            this.courseCodeTextBox.Location = new System.Drawing.Point(129, 31);
            this.courseCodeTextBox.Name = "courseCodeTextBox";
            this.courseCodeTextBox.Size = new System.Drawing.Size(197, 20);
            this.courseCodeTextBox.TabIndex = 1;
            // 
            // CourseEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 244);
            this.Controls.Add(this.groupBox1);
            this.Name = "CourseEntryUI";
            this.Text = "Course Entry UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox courseTitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseCreditTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseCodeTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label4;
    }
}