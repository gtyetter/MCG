using System;

namespace MCG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.juniorGet = new System.Windows.Forms.Button();
            this.seniorGet = new System.Windows.Forms.Button();
            this.schoolsGet = new System.Windows.Forms.Button();
            this.headerGet = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.juniorTest = new System.Windows.Forms.TextBox();
            this.seniorTest = new System.Windows.Forms.TextBox();
            this.schoolList = new System.Windows.Forms.TextBox();
            this.scriptHeader = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Dayz = new System.Windows.Forms.ComboBox();
            this.Yearz = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            //this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            //this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // juniorGet
            // 
            this.juniorGet.Location = new System.Drawing.Point(360, 15);
            this.juniorGet.Name = "juniorGet";
            this.juniorGet.Size = new System.Drawing.Size(121, 20);
            this.juniorGet.TabIndex = 0;
            this.juniorGet.Text = "Get Junior Test";
            this.juniorGet.UseVisualStyleBackColor = true;
            this.juniorGet.Click += new System.EventHandler(this.juniorGet_Click);
            // 
            // seniorGet
            // 
            this.seniorGet.Location = new System.Drawing.Point(360, 44);
            this.seniorGet.Name = "seniorGet";
            this.seniorGet.Size = new System.Drawing.Size(121, 20);
            this.seniorGet.TabIndex = 1;
            this.seniorGet.Text = "Get Senior Test";
            this.seniorGet.UseVisualStyleBackColor = true;
            this.seniorGet.Click += new System.EventHandler(this.seniorGet_Click);
            // 
            // schoolsGet
            // 
            this.schoolsGet.Location = new System.Drawing.Point(360, 73);
            this.schoolsGet.Name = "schoolsGet";
            this.schoolsGet.Size = new System.Drawing.Size(121, 20);
            this.schoolsGet.TabIndex = 2;
            this.schoolsGet.Text = "Get Schools List";
            this.schoolsGet.UseVisualStyleBackColor = true;
            this.schoolsGet.Click += new System.EventHandler(this.schoolsGet_Click);
            // 
            // headerGet
            // 
            this.headerGet.Location = new System.Drawing.Point(360, 102);
            this.headerGet.Name = "headerGet";
            this.headerGet.Size = new System.Drawing.Size(121, 20);
            this.headerGet.TabIndex = 3;
            this.headerGet.Text = "Get Script Header";
            this.headerGet.UseVisualStyleBackColor = true;
            this.headerGet.Click += new System.EventHandler(this.headerGet_Click);
            // 
            // go
            // 
            this.go.Enabled = false;
            this.go.Location = new System.Drawing.Point(359, 162);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(121, 20);
            this.go.TabIndex = 4;
            this.go.Text = "BFG";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // juniorTest
            // 
            this.juniorTest.Location = new System.Drawing.Point(12, 15);
            this.juniorTest.Name = "juniorTest";
            this.juniorTest.ReadOnly = true;
            this.juniorTest.Size = new System.Drawing.Size(342, 20);
            this.juniorTest.TabIndex = 5;
            this.juniorTest.Text = "Select Junior Test to Read Scores";
            // 
            // seniorTest
            // 
            this.seniorTest.Location = new System.Drawing.Point(12, 45);
            this.seniorTest.Name = "seniorTest";
            this.seniorTest.ReadOnly = true;
            this.seniorTest.Size = new System.Drawing.Size(342, 20);
            this.seniorTest.TabIndex = 6;
            this.seniorTest.Text = "Select Senior Test to Read Scores";
            // 
            // schoolList
            // 
            this.schoolList.Location = new System.Drawing.Point(12, 73);
            this.schoolList.Name = "schoolList";
            this.schoolList.ReadOnly = true;
            this.schoolList.Size = new System.Drawing.Size(342, 20);
            this.schoolList.TabIndex = 7;
            this.schoolList.Text = "Select List of Schools";
            // 
            // scriptHeader
            // 
            this.scriptHeader.Location = new System.Drawing.Point(12, 102);
            this.scriptHeader.Name = "scriptHeader";
            this.scriptHeader.ReadOnly = true;
            this.scriptHeader.Size = new System.Drawing.Size(342, 20);
            this.scriptHeader.TabIndex = 8;
            this.scriptHeader.Text = "Select Script Header File";
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.Month.Location = new System.Drawing.Point(12, 160);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(113, 21);
            this.Month.TabIndex = 9;
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // Dayz
            // 
            this.Dayz.FormattingEnabled = true;
            this.Dayz.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Dayz.Location = new System.Drawing.Point(132, 160);
            this.Dayz.Name = "Dayz";
            this.Dayz.Size = new System.Drawing.Size(46, 21);
            this.Dayz.TabIndex = 10;
            // 
            // Yearz
            // 
            this.Yearz.FormattingEnabled = true;
            this.Yearz.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.Yearz.Location = new System.Drawing.Point(185, 160);
            this.Yearz.Name = "Yearz";
            this.Yearz.Size = new System.Drawing.Size(76, 21);
            this.Yearz.TabIndex = 11;
            this.Yearz.SelectedIndexChanged += new System.EventHandler(this.Yearz_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Year";
            // 
            // shapeContainer1
            // 
            /*
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(495, 196);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            */
            // 
            // lineShape1
            // 
            /*
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 476;
            this.lineShape1.Y1 = 135;
            this.lineShape1.Y2 = 135;
            */
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yearz);
            this.Controls.Add(this.Dayz);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.scriptHeader);
            this.Controls.Add(this.schoolList);
            this.Controls.Add(this.seniorTest);
            this.Controls.Add(this.juniorTest);
            this.Controls.Add(this.go);
            this.Controls.Add(this.headerGet);
            this.Controls.Add(this.schoolsGet);
            this.Controls.Add(this.seniorGet);
            this.Controls.Add(this.juniorGet);
            //this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Contest Grading Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button juniorGet;
        private System.Windows.Forms.Button seniorGet;
        private System.Windows.Forms.Button schoolsGet;
        private System.Windows.Forms.Button headerGet;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox juniorTest;
        private System.Windows.Forms.TextBox seniorTest;
        private System.Windows.Forms.TextBox schoolList;
        private System.Windows.Forms.TextBox scriptHeader;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Dayz;
        private System.Windows.Forms.ComboBox Yearz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

