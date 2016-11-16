namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.labelSemesterDate = new System.Windows.Forms.Label();
            this.labelSemesterType = new System.Windows.Forms.Label();
            this.boxSemesterType = new System.Windows.Forms.ComboBox();
            this.boxSemesterDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculateDays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSemesterDate
            // 
            this.labelSemesterDate.AutoSize = true;
            this.labelSemesterDate.Location = new System.Drawing.Point(12, 187);
            this.labelSemesterDate.Name = "labelSemesterDate";
            this.labelSemesterDate.Size = new System.Drawing.Size(190, 13);
            this.labelSemesterDate.TabIndex = 0;
            this.labelSemesterDate.Text = "Please Enter The Semester Start Date:";
            // 
            // labelSemesterType
            // 
            this.labelSemesterType.AutoSize = true;
            this.labelSemesterType.Location = new System.Drawing.Point(12, 109);
            this.labelSemesterType.Name = "labelSemesterType";
            this.labelSemesterType.Size = new System.Drawing.Size(147, 13);
            this.labelSemesterType.TabIndex = 2;
            this.labelSemesterType.Text = "Please Enter Semester Type: ";
            // 
            // boxSemesterType
            // 
            this.boxSemesterType.FormattingEnabled = true;
            this.boxSemesterType.Items.AddRange(new object[] {
            "Fall Semester",
            "Fall Mini-Mester",
            "Spring Semester",
            "Spring Mini-Mester",
            "Summer Session"});
            this.boxSemesterType.Location = new System.Drawing.Point(232, 101);
            this.boxSemesterType.Name = "boxSemesterType";
            this.boxSemesterType.Size = new System.Drawing.Size(121, 21);
            this.boxSemesterType.TabIndex = 4;
            // 
            // boxSemesterDate
            // 
            this.boxSemesterDate.Location = new System.Drawing.Point(232, 180);
            this.boxSemesterDate.Name = "boxSemesterDate";
            this.boxSemesterDate.Size = new System.Drawing.Size(200, 20);
            this.boxSemesterDate.TabIndex = 5;
            // 
            // buttonCalculateDays
            // 
            this.buttonCalculateDays.Location = new System.Drawing.Point(162, 237);
            this.buttonCalculateDays.Name = "buttonCalculateDays";
            this.buttonCalculateDays.Size = new System.Drawing.Size(121, 37);
            this.buttonCalculateDays.TabIndex = 6;
            this.buttonCalculateDays.Text = "Calculate Days";
            this.buttonCalculateDays.UseVisualStyleBackColor = true;
            this.buttonCalculateDays.Click += new System.EventHandler(this.buttonCalculateDays_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 300);
            this.Controls.Add(this.buttonCalculateDays);
            this.Controls.Add(this.boxSemesterDate);
            this.Controls.Add(this.boxSemesterType);
            this.Controls.Add(this.labelSemesterType);
            this.Controls.Add(this.labelSemesterDate);
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemesterDate;
        private System.Windows.Forms.Label labelSemesterType;
        private System.Windows.Forms.ComboBox boxSemesterType;
        private System.Windows.Forms.DateTimePicker boxSemesterDate;
        private System.Windows.Forms.Button buttonCalculateDays;
    }
}

