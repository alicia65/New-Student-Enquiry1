namespace New_Student_Enquiry1
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.cbxHowDidYouHear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDegrees = new System.Windows.Forms.ListBox();
            this.lblDegreeCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(197, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(30, 35);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(448, 24);
            this.cbxDepartment.TabIndex = 0;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // cbxHowDidYouHear
            // 
            this.cbxHowDidYouHear.FormattingEnabled = true;
            this.cbxHowDidYouHear.Location = new System.Drawing.Point(30, 223);
            this.cbxHowDidYouHear.Name = "cbxHowDidYouHear";
            this.cbxHowDidYouHear.Size = new System.Drawing.Size(448, 24);
            this.cbxHowDidYouHear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which department are you interested in?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "How did you hear about us?";
            // 
            // lstDegrees
            // 
            this.lstDegrees.FormattingEnabled = true;
            this.lstDegrees.ItemHeight = 16;
            this.lstDegrees.Location = new System.Drawing.Point(30, 75);
            this.lstDegrees.Name = "lstDegrees";
            this.lstDegrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDegrees.Size = new System.Drawing.Size(448, 84);
            this.lstDegrees.Sorted = true;
            this.lstDegrees.TabIndex = 5;
            this.lstDegrees.SelectedIndexChanged += new System.EventHandler(this.lstDegrees_SelectedIndexChanged);
            // 
            // lblDegreeCount
            // 
            this.lblDegreeCount.Location = new System.Drawing.Point(378, 162);
            this.lblDegreeCount.Name = "lblDegreeCount";
            this.lblDegreeCount.Size = new System.Drawing.Size(100, 23);
            this.lblDegreeCount.TabIndex = 6;
            this.lblDegreeCount.Text = "0 selected";
            this.lblDegreeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 288);
            this.Controls.Add(this.lblDegreeCount);
            this.Controls.Add(this.lstDegrees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxHowDidYouHear);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Student  Enquiry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.ComboBox cbxHowDidYouHear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDegrees;
        private System.Windows.Forms.Label lblDegreeCount;
    }
}

