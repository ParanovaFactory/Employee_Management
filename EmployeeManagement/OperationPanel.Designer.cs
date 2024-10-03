namespace EmployeeManagement
{
    partial class OperationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationPanel));
            this.GrpEmpInfo = new System.Windows.Forms.GroupBox();
            this.RbSingle = new System.Windows.Forms.RadioButton();
            this.RbMarry = new System.Windows.Forms.RadioButton();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtJob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GrpProcess = new System.Windows.Forms.GroupBox();
            this.BtnChart = new System.Windows.Forms.Button();
            this.BtnStatistic = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpRecords = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblId = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.GrpEmpInfo.SuspendLayout();
            this.GrpProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpEmpInfo
            // 
            this.GrpEmpInfo.Controls.Add(this.RbSingle);
            this.GrpEmpInfo.Controls.Add(this.RbMarry);
            this.GrpEmpInfo.Controls.Add(this.CmbCity);
            this.GrpEmpInfo.Controls.Add(this.label1);
            this.GrpEmpInfo.Controls.Add(this.label6);
            this.GrpEmpInfo.Controls.Add(this.TxtName);
            this.GrpEmpInfo.Controls.Add(this.label5);
            this.GrpEmpInfo.Controls.Add(this.TxtJob);
            this.GrpEmpInfo.Controls.Add(this.label4);
            this.GrpEmpInfo.Controls.Add(this.TxtSurname);
            this.GrpEmpInfo.Controls.Add(this.label3);
            this.GrpEmpInfo.Controls.Add(this.label2);
            this.GrpEmpInfo.Controls.Add(this.TxtSalary);
            this.GrpEmpInfo.ForeColor = System.Drawing.Color.White;
            this.GrpEmpInfo.Location = new System.Drawing.Point(13, 13);
            this.GrpEmpInfo.Name = "GrpEmpInfo";
            this.GrpEmpInfo.Size = new System.Drawing.Size(273, 223);
            this.GrpEmpInfo.TabIndex = 0;
            this.GrpEmpInfo.TabStop = false;
            this.GrpEmpInfo.Text = "Add Employee";
            // 
            // RbSingle
            // 
            this.RbSingle.AutoSize = true;
            this.RbSingle.Location = new System.Drawing.Point(183, 157);
            this.RbSingle.Name = "RbSingle";
            this.RbSingle.Size = new System.Drawing.Size(71, 24);
            this.RbSingle.TabIndex = 6;
            this.RbSingle.TabStop = true;
            this.RbSingle.Text = "Single";
            this.RbSingle.UseVisualStyleBackColor = true;
            // 
            // RbMarry
            // 
            this.RbMarry.AutoSize = true;
            this.RbMarry.Location = new System.Drawing.Point(111, 157);
            this.RbMarry.Name = "RbMarry";
            this.RbMarry.Size = new System.Drawing.Size(66, 24);
            this.RbMarry.TabIndex = 5;
            this.RbMarry.TabStop = true;
            this.RbMarry.Text = "Marry";
            this.RbMarry.UseVisualStyleBackColor = true;
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.CmbCity.Location = new System.Drawing.Point(111, 89);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(143, 28);
            this.CmbCity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Job";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 25);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(143, 26);
            this.TxtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Marry Status";
            // 
            // TxtJob
            // 
            this.TxtJob.Location = new System.Drawing.Point(111, 188);
            this.TxtJob.Name = "TxtJob";
            this.TxtJob.Size = new System.Drawing.Size(143, 26);
            this.TxtJob.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salary";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(111, 57);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(143, 26);
            this.TxtSurname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(111, 123);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(143, 26);
            this.TxtSalary.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(70, 25);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(58, 33);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // GrpProcess
            // 
            this.GrpProcess.Controls.Add(this.BtnChart);
            this.GrpProcess.Controls.Add(this.BtnStatistic);
            this.GrpProcess.Controls.Add(this.BtnDelete);
            this.GrpProcess.Controls.Add(this.BtnAdd);
            this.GrpProcess.Controls.Add(this.BtnUpdate);
            this.GrpProcess.Controls.Add(this.BtnList);
            this.GrpProcess.ForeColor = System.Drawing.Color.White;
            this.GrpProcess.Location = new System.Drawing.Point(292, 12);
            this.GrpProcess.Name = "GrpProcess";
            this.GrpProcess.Size = new System.Drawing.Size(137, 224);
            this.GrpProcess.TabIndex = 1;
            this.GrpProcess.TabStop = false;
            this.GrpProcess.Text = "Process Menu";
            // 
            // BtnChart
            // 
            this.BtnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChart.Location = new System.Drawing.Point(6, 180);
            this.BtnChart.Name = "BtnChart";
            this.BtnChart.Size = new System.Drawing.Size(122, 34);
            this.BtnChart.TabIndex = 23;
            this.BtnChart.Text = "Charts";
            this.BtnChart.UseVisualStyleBackColor = true;
            this.BtnChart.Click += new System.EventHandler(this.BtnChart_Click);
            // 
            // BtnStatistic
            // 
            this.BtnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStatistic.Location = new System.Drawing.Point(6, 140);
            this.BtnStatistic.Name = "BtnStatistic";
            this.BtnStatistic.Size = new System.Drawing.Size(122, 34);
            this.BtnStatistic.TabIndex = 22;
            this.BtnStatistic.Text = "Statistic";
            this.BtnStatistic.UseVisualStyleBackColor = true;
            this.BtnStatistic.Click += new System.EventHandler(this.BtnStatistic_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(6, 103);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(122, 31);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Location = new System.Drawing.Point(6, 61);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(122, 36);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnList
            // 
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Location = new System.Drawing.Point(6, 25);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(58, 33);
            this.BtnList.TabIndex = 8;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(646, 185);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(55, 48);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GrpRecords
            // 
            this.GrpRecords.Controls.Add(this.dataGridView1);
            this.GrpRecords.ForeColor = System.Drawing.Color.White;
            this.GrpRecords.Location = new System.Drawing.Point(12, 243);
            this.GrpRecords.Name = "GrpRecords";
            this.GrpRecords.Size = new System.Drawing.Size(689, 268);
            this.GrpRecords.TabIndex = 20;
            this.GrpRecords.TabStop = false;
            this.GrpRecords.Text = "Recodrs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 243);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(435, 13);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(97, 20);
            this.LblId.TabIndex = 21;
            this.LblId.Text = "Employee Id";
            this.LblId.Visible = false;
            // 
            // BtnClean
            // 
            this.BtnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClean.Location = new System.Drawing.Point(567, 185);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(73, 48);
            this.BtnClean.TabIndex = 12;
            this.BtnClean.Text = "Clean";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReports.Location = new System.Drawing.Point(439, 185);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(122, 48);
            this.BtnReports.TabIndex = 22;
            this.BtnReports.Text = "Reports";
            this.BtnReports.UseVisualStyleBackColor = true;
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // OperationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(713, 526);
            this.Controls.Add(this.BtnReports);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.GrpRecords);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GrpProcess);
            this.Controls.Add(this.GrpEmpInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OperationPanel";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpEmpInfo.ResumeLayout(false);
            this.GrpEmpInfo.PerformLayout();
            this.GrpProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpEmpInfo;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.GroupBox GrpProcess;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.RadioButton RbSingle;
        private System.Windows.Forms.RadioButton RbMarry;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GrpRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnStatistic;
        private System.Windows.Forms.Button BtnChart;
        private System.Windows.Forms.Button BtnReports;
    }
}

