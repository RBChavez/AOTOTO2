namespace AOTOTO
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
            this.LB_Import_test_case = new System.Windows.Forms.Label();
            this.TB_Import_Test_Case_Location = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BT_Browse_Import_Test_Case = new System.Windows.Forms.Button();
            this.LB_Report_Location = new System.Windows.Forms.Label();
            this.TB_Report_Location = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.BT_Browse_Report_Location = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Import_test_case
            // 
            this.LB_Import_test_case.AutoSize = true;
            this.LB_Import_test_case.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Import_test_case.Location = new System.Drawing.Point(49, 70);
            this.LB_Import_test_case.Name = "LB_Import_test_case";
            this.LB_Import_test_case.Size = new System.Drawing.Size(108, 17);
            this.LB_Import_test_case.TabIndex = 0;
            this.LB_Import_test_case.Text = "Import test case";
            // 
            // TB_Import_Test_Case_Location
            // 
            this.TB_Import_Test_Case_Location.Location = new System.Drawing.Point(163, 69);
            this.TB_Import_Test_Case_Location.Name = "TB_Import_Test_Case_Location";
            this.TB_Import_Test_Case_Location.Size = new System.Drawing.Size(428, 20);
            this.TB_Import_Test_Case_Location.TabIndex = 1;
            this.TB_Import_Test_Case_Location.Text = "Y:\\1_Aoy_Document\\0_Harrisburg University\\Project_Grad_HU\\TestCase_001.xlsx";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BT_Browse_Import_Test_Case
            // 
            this.BT_Browse_Import_Test_Case.Location = new System.Drawing.Point(597, 67);
            this.BT_Browse_Import_Test_Case.Name = "BT_Browse_Import_Test_Case";
            this.BT_Browse_Import_Test_Case.Size = new System.Drawing.Size(75, 23);
            this.BT_Browse_Import_Test_Case.TabIndex = 2;
            this.BT_Browse_Import_Test_Case.Text = "Browse";
            this.BT_Browse_Import_Test_Case.UseVisualStyleBackColor = true;
            this.BT_Browse_Import_Test_Case.Click += new System.EventHandler(this.BT_Browse_Import_File_Click);
            // 
            // LB_Report_Location
            // 
            this.LB_Report_Location.AutoSize = true;
            this.LB_Report_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Report_Location.Location = new System.Drawing.Point(49, 159);
            this.LB_Report_Location.Name = "LB_Report_Location";
            this.LB_Report_Location.Size = new System.Drawing.Size(104, 17);
            this.LB_Report_Location.TabIndex = 4;
            this.LB_Report_Location.Text = "Report location";
            // 
            // TB_Report_Location
            // 
            this.TB_Report_Location.Location = new System.Drawing.Point(163, 159);
            this.TB_Report_Location.Name = "TB_Report_Location";
            this.TB_Report_Location.Size = new System.Drawing.Size(428, 20);
            this.TB_Report_Location.TabIndex = 8;
            this.TB_Report_Location.Text = "Y:\\1_Aoy_Document\\0_Harrisburg University\\Project_Grad_HU\\";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // BT_Browse_Report_Location
            // 
            this.BT_Browse_Report_Location.Location = new System.Drawing.Point(597, 160);
            this.BT_Browse_Report_Location.Name = "BT_Browse_Report_Location";
            this.BT_Browse_Report_Location.Size = new System.Drawing.Size(75, 23);
            this.BT_Browse_Report_Location.TabIndex = 9;
            this.BT_Browse_Report_Location.Text = "Browse";
            this.BT_Browse_Report_Location.UseVisualStyleBackColor = true;
            this.BT_Browse_Report_Location.Click += new System.EventHandler(this.BT_Browse_Report_Location_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cancel.Location = new System.Drawing.Point(52, 345);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(620, 56);
            this.BT_Cancel.TabIndex = 10;
            this.BT_Cancel.Text = "Report";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Start
            // 
            this.BT_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Start.Location = new System.Drawing.Point(51, 246);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(621, 49);
            this.BT_Start.TabIndex = 11;
            this.BT_Start.Text = "Start";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "1. Select test case file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "2. Select folder for test result report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "3. Click \'Start\' button to run test cases";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "4. Check test results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 430);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_Start);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Browse_Report_Location);
            this.Controls.Add(this.TB_Report_Location);
            this.Controls.Add(this.LB_Report_Location);
            this.Controls.Add(this.BT_Browse_Import_Test_Case);
            this.Controls.Add(this.TB_Import_Test_Case_Location);
            this.Controls.Add(this.LB_Import_test_case);
            this.Name = "Form1";
            this.Text = "AOTOTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Import_test_case;
        private System.Windows.Forms.TextBox TB_Import_Test_Case_Location;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BT_Browse_Import_Test_Case;
        private System.Windows.Forms.Label LB_Report_Location;
        private System.Windows.Forms.TextBox TB_Report_Location;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button BT_Browse_Report_Location;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

