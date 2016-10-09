using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCG
{
    public partial class Form1 : Form
    {
        #region VariableDefanitions
        bool jun = false;
        bool sen = false;
        bool sch = false;
        bool head = false;

        string date;

        //Vector for Juniors
        List<Student> Juniors = new List<Student>();
        //Vector for Seniors
        List<Student> Seniors = new List<Student>();

        string juniorKey;
        string juniorTie;
        string seniorKey;
        string seniorTie;
        #endregion VariableDefanitions

        public Form1()
        {
            InitializeComponent();
        }

        private void juniorGet_Click(object sender, EventArgs e)
        {
            OpenFileDialog juniorTestOpen = new OpenFileDialog();
            juniorTestOpen.Filter = "Text Files|*.txt";
            if (juniorTestOpen.ShowDialog()==DialogResult.OK)
            {
                string juniorFile = juniorTestOpen.FileName;
                juniorTest.Text = juniorFile;
                juniorTest.Update();
                jun = true;
                if (jun && sen && sch && head)
                {
                    go.Enabled = true;
                }
            }
        }

        private void seniorGet_Click(object sender, EventArgs e)
        {
            OpenFileDialog seniorTestOpen = new OpenFileDialog();
            seniorTestOpen.Filter = "Text Files|*.txt";
            if (seniorTestOpen.ShowDialog() == DialogResult.OK)
            {
                string seniorFile = seniorTestOpen.FileName;
                seniorTest.Text = seniorFile;
                seniorTest.Update();
                sen = true;
                if (jun && sen && sch && head)
                {
                    go.Enabled = true;
                }
            }
        }

        private void schoolsGet_Click(object sender, EventArgs e)
        {
            OpenFileDialog schoolOpen = new OpenFileDialog();
            schoolOpen.Filter = "Text Files|*.txt";
            if (schoolOpen.ShowDialog() == DialogResult.OK)
            {
                string schoolFile = schoolOpen.FileName;
                schoolList.Text = schoolFile;
                schoolList.Update();
                sch = true;
                if (jun && sen && sch && head)
                {
                    go.Enabled = true;
                }
            }
        }

        private void headerGet_Click(object sender, EventArgs e)
        {
            OpenFileDialog scriptHeaderOpen = new OpenFileDialog();
            scriptHeaderOpen.Filter = "Text Files|*.txt";
            if (scriptHeaderOpen.ShowDialog() == DialogResult.OK)
            {
                string scriptHeaderFile = scriptHeaderOpen.FileName;
                scriptHeader.Text = scriptHeaderFile;
                scriptHeader.Update();
                head = true;
                if (jun && sen && sch && head)
                {
                    go.Enabled = true;
                }
            }
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jun && sen && sch && head)
            {
                go.Enabled = true;
            }
        }

        private void Yearz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jun && sen && sch && head)
            {
                go.Enabled = true;
            }
        }

        private void Dayz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jun && sen && sch && head)
            {
                go.Enabled = true;
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            date = Month.Text + " " + Dayz.Text + ", " + Yearz.Text;
            MessageBox.Show(date);
            if(Verify())
            {
                FormallyGrade();
                MessageBox.Show("Got True from Verify\nFormally Graded");
            }
            else
            {
                MessageBox.Show("Got False in Verify");
            }
        }

        bool Verify()
        {
            /*
            Ensure Key is 40 Chars Long
            Ensure Tie is 40 Chars Long

            Ensure Student Name is not "Unknown Student"
            Division and Class is not "*********"
            School is not "??????"

            If Errors, Store the whole line and print to verify file
            Continue until everything is done.

            If Data is good, put it in the vectors and classes for Formally Grade

            Return true/false;

            */


            //Insert the Verify Code Here
            //If Verified Good return true
            //If Bad Data return false
            return true;
        }

        void FormallyGrade()
        {
            //Insert the Grade Stuff Here
        }


    }
}
