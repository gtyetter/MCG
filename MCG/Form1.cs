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
            char[] whitespace = new char[] { '\t' };
            List<string> splitJunLine;
            List<string> splitSenLine;

            List<int> junOOPS=new List<int>();
            List<int> senOOPS=new List<int>();

            bool senErr = false;
            bool junErr = false;

            string last;
            string first;
            string mi;
            string code;
            string schoolcode;
            string answers;


            int counter = 0;
            string line;
            System.IO.StreamReader junFile= new System.IO.StreamReader(juniorTest.Text);
            while((line=junFile.ReadLine())!=null)
            {
                splitJunLine=killWhiteSpace(line.Split(whitespace));
                MessageBox.Show(splitJunLine[0]);
                //Tests the Key
                if(splitJunLine[0]=="JUNIORTESTKEY")
                {
                    if(splitJunLine[2].Length==40)
                    {
                        juniorKey=splitJunLine[2];
                        for(int i=1;i<40;i++)
                        {
                            if(juniorKey[i]!='1'||juniorKey[i]!='2'||juniorKey[i]!='3'||juniorKey[i]!='4'||juniorKey[i]!='5'||juniorKey[i]!='*')
                            {
                                junOOPS.Add(0);
                                break;
                            }
                        }
                    }
                    else
                    {
                        junOOPS.Add(0);
                    } 
                }

                //Tests the TieBreaker
                else if (splitJunLine[0] == "JUNIORTIEBREAKER")
                {
                    if (splitJunLine[2].Length == 40)
                    {
                        juniorTie = splitJunLine[2];
                        for (int i = 1; i < 40; i++)
                        {
                            if (juniorTie[i] != '1' || juniorTie[i] != '2' || juniorTie[i] != '*')
                            {
                                junOOPS.Add(1);
                                break;
                            }
                        }
                    }
                    else
                    {
                        junOOPS.Add(1);
                    }
                }
                else
                {
                    //Tests the Student Stuff
                    Juniors.Add(validJunior(splitJunLine));
                    if (Juniors[Juniors.Count() - 1].returnAnswers() == "") { junOOPS.Add(counter); }
                }
                counter++;
            }

            //Senior Files
            counter = 0;
            System.IO.StreamReader senFile= new System.IO.StreamReader(seniorTest.Text);
            while((line=senFile.ReadLine())!=null)
            {
                splitSenLine = killWhiteSpace(line.Split(whitespace));
                //Tests the Key
                MessageBox.Show(splitSenLine[0] + " " + splitSenLine[1] + " " + splitSenLine[2]);
                if(splitSenLine[0]=="SENIORTESTKEY")
                {
                    MessageBox.Show(splitSenLine[0] + " " + splitSenLine[1] + " " + splitSenLine[2]);
                    if(splitSenLine[2].Length==40)
                    {
                        seniorKey=splitSenLine[2];
                        for(int i=1;i<40;i++)
                        {
                            if(seniorKey[i]!='1'||seniorKey[i]!='2'||seniorKey[i]!='3'||seniorKey[i]!='4'||seniorKey[i]!='5'||seniorKey[i]!='*')
                            {
                                senOOPS.Add(0);
                                break;
                            }
                        }
                    }
                    else
                    {
                        senOOPS.Add(0);
                    } 
                }

                //Tests the TieBreaker
                else if (splitSenLine[0] == "SENIORTIEBREAKER")
                {
                    MessageBox.Show(splitSenLine[0] + " " + splitSenLine[1] + " " + splitSenLine[2]);
                    if (splitSenLine[2].Length == 40)
                    {
                        juniorTie = splitSenLine[2];
                        for (int i = 1; i < 40; i++)
                        {
                            if (seniorTie[i] != '1' || seniorTie[i] != '2' || seniorTie[i] != '*')
                            {
                                senOOPS.Add(1);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(splitSenLine[0] + " " + splitSenLine[1] + " " + splitSenLine[2]);
                        senOOPS.Add(1);
                    }
                }
                else
                {
                    //Tests the Student Stuff
                    Seniors.Add(validSenior(splitSenLine));
                    if (Seniors[Seniors.Count() - 1].returnAnswers() == "") { senOOPS.Add(counter); }
                    counter++;
                }






                counter++;
            }
            //Insert the Verify Code Here
            //If Verified Good return true
            //If Bad Data return false

            string dasJE = "";
            string dasSE = "";

            for (int i = 0; i < junOOPS.Count(); i++)
            {
                dasJE=dasJE+junOOPS[i].ToString()+"\n";
                junErr=true;
            }
            for (int i = 0; i < senOOPS.Count(); i++)
            {
                dasSE=dasSE+senOOPS[i].ToString()+"\n";
                senErr=true;
            }

            if (junErr) { MessageBox.Show("Error in Junior Test\n"+dasJE); }
            if (senErr) { MessageBox.Show("Error in Senior Test\n"+dasSE); }








            return !junErr&&!senErr;
        }

        void FormallyGrade()
        {
            //Insert the Grade Stuff Here
        }

        Student validJunior(List<string> splitJunLine)
        {
            string last="";
            string first="";
            string mi="";
            string code="";
            string schoolcode="";
            string answers="";
            Student it;
            //Tests the Student Stuff
            if (splitJunLine.Count() == 5)
            {
                last = splitJunLine[0];
                first = splitJunLine[1];
                mi = " ";
                code = splitJunLine[2];
                schoolcode = splitJunLine[3];
                answers = splitJunLine[4];

                if (last != "Student" && first != "Unknown" && schoolcode != "??????")
                {
                    it=new Student("Junior", last, first, mi, code, schoolcode, answers);
                }
                else
                {
                    it = new Student("ERROR", last, first, mi, code, schoolcode, answers);
                }
            }

            else if (splitJunLine.Count() == 6)
            {
                last = splitJunLine[0];
                first = splitJunLine[1];
                mi = splitJunLine[2];
                code = splitJunLine[3];
                schoolcode = splitJunLine[4];
                answers = splitJunLine[5];

                if (last != "Student" && first != "Unknown" && schoolcode != "??????")
                {
                    it=new Student("Junior", last, first, mi, code, schoolcode, answers);
                }
                else
                {
                    it = new Student("ERROR", last, first, mi, code, schoolcode, answers);
                }
            }
            else
            {
                it=new Student("ERROR", last, first, mi, code, schoolcode, answers);
            }
            return it;
        }

        Student validSenior(List<string> splitJunLine)
        {
            string last = "";
            string first = "";
            string mi = "";
            string code = "";
            string schoolcode = "";
            string answers = "";
            Student it;
            //Tests the Student Stuff
            if (splitJunLine.Count() == 5)
            {
                last = splitJunLine[0];
                first = splitJunLine[1];
                mi = " ";
                code = splitJunLine[2];
                schoolcode = splitJunLine[3];
                answers = splitJunLine[4];

                if (last != "Student" && first != "Unknown" && schoolcode != "??????")
                {
                    it = new Student("Senior", last, first, mi, code, schoolcode, answers);
                }
                else
                {
                    it = new Student("ERROR", last, first, mi, code, schoolcode, answers);
                }
            }

            else if (splitJunLine.Count() == 6)
            {
                last = splitJunLine[0];
                first = splitJunLine[1];
                mi = splitJunLine[2];
                code = splitJunLine[3];
                schoolcode = splitJunLine[4];
                answers = splitJunLine[5];

                if (last != "Student" && first != "Unknown" && schoolcode != "??????")
                {
                    it = new Student("Senior", last, first, mi, code, schoolcode, answers);
                }
                else
                {
                    it = new Student("ERROR", last, first, mi, code, schoolcode, answers);
                }
            }
            else
            {
                it = new Student("ERROR", last, first, mi, code, schoolcode, answers);
            }
            return it;
        }

        List<string> killWhiteSpace(string[] it)
        {
            List<string> that = new List<string>();
            for(int i=0;i<(it.Count()-1);i++)
            {
                if(it[i]!=" ")
                {
                    that.Add(it[i]);
                }
            }
            return that;
        }
    }
}
