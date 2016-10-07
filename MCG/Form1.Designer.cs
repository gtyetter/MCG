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
            this.juniorGet = new System.Windows.Forms.Button();
            this.seniorGet = new System.Windows.Forms.Button();
            this.schoolsGet = new System.Windows.Forms.Button();
            this.headerGet = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.juniorTest = new System.Windows.Forms.TextBox();
            this.seniorTest = new System.Windows.Forms.TextBox();
            this.schoolList = new System.Windows.Forms.TextBox();
            this.scriptHeader = new System.Windows.Forms.TextBox();
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
            this.go.Location = new System.Drawing.Point(360, 131);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 165);
            this.Controls.Add(this.scriptHeader);
            this.Controls.Add(this.schoolList);
            this.Controls.Add(this.seniorTest);
            this.Controls.Add(this.juniorTest);
            this.Controls.Add(this.go);
            this.Controls.Add(this.headerGet);
            this.Controls.Add(this.schoolsGet);
            this.Controls.Add(this.seniorGet);
            this.Controls.Add(this.juniorGet);
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
    }
}

