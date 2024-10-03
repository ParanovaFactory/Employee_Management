namespace EmployeeManagement
{
    partial class Statistic
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNumOfEmp = new System.Windows.Forms.Label();
            this.LblMarryEmp = new System.Windows.Forms.Label();
            this.LblSingleEmp = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblSalrySum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSalryAvg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(170, 132);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(148, 37);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Close";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number of Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number of Married Employee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number of Single Employee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number of City";
            // 
            // LblNumOfEmp
            // 
            this.LblNumOfEmp.AutoSize = true;
            this.LblNumOfEmp.Location = new System.Drawing.Point(236, 9);
            this.LblNumOfEmp.Name = "LblNumOfEmp";
            this.LblNumOfEmp.Size = new System.Drawing.Size(27, 20);
            this.LblNumOfEmp.TabIndex = 18;
            this.LblNumOfEmp.Text = "00";
            // 
            // LblMarryEmp
            // 
            this.LblMarryEmp.AutoSize = true;
            this.LblMarryEmp.Location = new System.Drawing.Point(236, 29);
            this.LblMarryEmp.Name = "LblMarryEmp";
            this.LblMarryEmp.Size = new System.Drawing.Size(27, 20);
            this.LblMarryEmp.TabIndex = 24;
            this.LblMarryEmp.Text = "00";
            // 
            // LblSingleEmp
            // 
            this.LblSingleEmp.AutoSize = true;
            this.LblSingleEmp.Location = new System.Drawing.Point(236, 49);
            this.LblSingleEmp.Name = "LblSingleEmp";
            this.LblSingleEmp.Size = new System.Drawing.Size(27, 20);
            this.LblSingleEmp.TabIndex = 25;
            this.LblSingleEmp.Text = "00";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(236, 69);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(27, 20);
            this.LblCity.TabIndex = 26;
            this.LblCity.Text = "00";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Get Statistic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblSalrySum
            // 
            this.LblSalrySum.AutoSize = true;
            this.LblSalrySum.Location = new System.Drawing.Point(236, 89);
            this.LblSalrySum.Name = "LblSalrySum";
            this.LblSalrySum.Size = new System.Drawing.Size(27, 20);
            this.LblSalrySum.TabIndex = 29;
            this.LblSalrySum.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Sum of Salary";
            // 
            // LblSalryAvg
            // 
            this.LblSalryAvg.AutoSize = true;
            this.LblSalryAvg.Location = new System.Drawing.Point(236, 109);
            this.LblSalryAvg.Name = "LblSalryAvg";
            this.LblSalryAvg.Size = new System.Drawing.Size(27, 20);
            this.LblSalryAvg.TabIndex = 31;
            this.LblSalryAvg.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Avarage of Salary";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(328, 182);
            this.Controls.Add(this.LblSalryAvg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblSalrySum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblSingleEmp);
            this.Controls.Add(this.LblMarryEmp);
            this.Controls.Add(this.LblNumOfEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNumOfEmp;
        private System.Windows.Forms.Label LblMarryEmp;
        private System.Windows.Forms.Label LblSingleEmp;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblSalrySum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSalryAvg;
        private System.Windows.Forms.Label label8;
    }
}