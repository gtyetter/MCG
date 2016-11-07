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
        bool sch = true;//false;
        bool head = true;//false;

        string date;

        //Vector for Juniors
        List<Student> Juniors = new List<Student>();
        //Vector for Seniors
        List<Student> Seniors = new List<Student>();

        //Sorted List for Juniors
        List<Student> SortJuniors = new List<Student>();
        //Sorted List for Seniors
        List<Student> SortSeniors = new List<Student>();

        string juniorKey;
        string juniorTie;
        string seniorKey;
        string seniorTie;

        bool jKEr = false;
        bool jTEr = false;
        bool sKEr = false;
        bool sTEr = false;

        #endregion VariableDefanitions

        public Form1()
        {
            InitializeComponent();
        }

        #region ClickActions

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
            //MessageBox.Show(date);
            if (Verify())
            {

                printVerifyFile(Juniors);
                printVerifyFile(Seniors);
                FormallyGrade();
                //MessageBox.Show("Got True from Verify\nFormally Graded");
            }
            else
            {
                printVerifyFile(Juniors);
                printVerifyFile(Seniors);
            }

            SortIt();
            outputFiles();
            MessageBox.Show("Grading is Complete\nPlease Check Files...");
        }

        #endregion ClickActions

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
            List<string> splitJunLine;
            bool isOK = false;

            //Junior Files
            #region JuniorPull

            int counter = 0;
            string line;
            System.IO.StreamReader junFile= new System.IO.StreamReader(juniorTest.Text);
            while((line=junFile.ReadLine())!=null)
            {
                if (counter==0)
                {
                    splitJunLine = killWhiteSpace(line);
                    if (splitJunLine[2].Count() != 40) { jKEr = true; }
                    else
                    {
                        for(int i=0;i<splitJunLine[2].Count();i++)
                        {
                            if (splitJunLine[2][i] != '1' && splitJunLine[2][i] != '2' && splitJunLine[2][i] != '3' && splitJunLine[2][i] != '4' && splitJunLine[2][i] != '5') { jKEr = true; }
                        }
                    }
                    juniorKey = splitJunLine[2];
                }
                else if(counter==1)
                {
                    splitJunLine = killWhiteSpace(line);
                    if (splitJunLine[2].Count() != 40) { jTEr = true; }
                    else
                    {
                        for (int i = 0; i < splitJunLine[2].Count(); i++)
                        {
                            if (splitJunLine[2][i] != '1' && splitJunLine[2][i] != '2' && splitJunLine[2][i] != '*') { jTEr = true; }
                        }
                    }
                    juniorTie = splitJunLine[2];
                }
                else
                { 
                    Juniors.Add(new Student("Junior",line));
                    //MessageBox.Show(Juniors[Juniors.Count() - 1].returnDebugString());
                    if (Juniors[Juniors.Count() - 1].isErr()) { isOK = false; }
                }
                //MessageBox.Show(counter.ToString());
                counter++;
            }
            junFile.Close();
            #endregion JuniorPull

            //Senior Files
            #region SeniorPull

            counter = 0;
            System.IO.StreamReader senFile= new System.IO.StreamReader(seniorTest.Text);
            while((line=senFile.ReadLine())!=null)
            {
                if (counter == 0)
                {
                    splitJunLine = killWhiteSpace(line);
                    if (splitJunLine[2].Count() != 40) { sKEr = true; }
                    else
                    {
                        for (int i = 0; i < splitJunLine[2].Count(); i++)
                        {
                            if (splitJunLine[2][i] != '1' && splitJunLine[2][i] != '2' && splitJunLine[2][i] != '3' && splitJunLine[2][i] != '4' && splitJunLine[2][i] != '5') { sKEr = true; }
                        }
                    }
                    seniorKey = splitJunLine[2];
                }
                else if (counter == 1)
                {
                    splitJunLine = killWhiteSpace(line);
                    if (splitJunLine[2].Count() != 40) { sTEr = true; }
                    else
                    {
                        for (int i = 0; i < splitJunLine[2].Count(); i++)
                        {
                            if (splitJunLine[2][i] != '1' && splitJunLine[2][i] != '2' && splitJunLine[2][i] != '*') { sTEr = true; }
                        }
                    }
                    seniorTie = splitJunLine[2];
                }
                else 
                { 
                    Seniors.Add(new Student("Senior",line));
                    if (Seniors[Seniors.Count() - 1].isErr()) { isOK = false; }
                }
                counter++;
            }
            senFile.Close();

            #endregion SeniorPull

            //MessageBox.Show(sKEr.ToString()+sTEr.ToString()+jKEr.ToString()+jTEr.ToString()+isOK.ToString());

            return !(!sKEr && !sTEr && !jKEr && !jTEr && isOK);
        }

        void FormallyGrade()
        {
            for(int i=0;i<Juniors.Count();i++)
            {
                Juniors[i].gradeIt(juniorKey,juniorTie);
            }
            for(int i=0;i<Seniors.Count();i++)
            {
                Seniors[i].gradeIt(seniorKey, seniorTie);
            }
        }

        List<string> killWhiteSpace(string it)
        {
            List<string> that = new List<string>();
            string blanko = "";
            for (int i = 0; i < it.Count();i++ )
            {
                if(it[i]!=' '&&it[i]!='\t')
                {
                    blanko = blanko + it[i];
                }
                else
                {
                    if(blanko.Count()!=0)
                    {
                        that.Add(blanko);
                        blanko = "";
                    }
                }
            }
            that.Add(blanko);
            return that;
        }

        void printVerifyFile(List<Student> them)
        {
            int counter = 0;
            string junErrList = "";
            for (int i = 0; i < them.Count(); i++)
            {
                if (them[i].isErr())
                {
                    junErrList = junErrList + them[i].returnDebugString() + "\n";
                    counter++;
                }
            }
            //MessageBox.Show(counter.ToString() + " Junior Errors out of " + them.Count() + "\n\n" + junErrList);
        }

        void SortIt()
        {
            for (int i = 0; i < Juniors.Count(); i++)
            {
                SortJuniors.Add(Juniors[i]);
            }
            for (int i = 0; i < Seniors.Count(); i++)
            {
                SortSeniors.Add(Seniors[i]);
            }
            SortJuniors=BubbleSort(SortJuniors);
            SortSeniors=BubbleSort(SortSeniors);
        }

        List<Student> BubbleSort(List<Student> it)
        {
            Student that;
            for(int i=0;i<it.Count();i++)
            {
                for(int j=0;j<it.Count()-i-1;j++)
                {
                    if(it[j].returnScore()<it[j+1].returnScore())
                    {
                        that = it[j];
                        it[j] = it[j + 1];
                        it[j + 1] = that;
                    }
                }
            }
            return it;
        }

        void outputFiles()
        {
            System.IO.StreamWriter jfile=new System.IO.StreamWriter("C:\\Users\\Patrick\\Desktop\\test data\\jfile.txt");
            string jline = "ANNUAL NORTHERN MINNESOTA MATHEMATICS CONTEST\n" + date + "\n\nDepartment of Mathematics and Computer Science\nBemidji State University\n\nJunior Dividion\n\nINDIVIDUAL RESULTS (INCLUDING TIEBREAKERS)\n\nRank  Score";
            jfile.WriteLine(jline + "\n");
            for(int i=0;i<SortJuniors.Count();i++)
            {
                jfile.WriteLine((i+1).ToString() + ".  " + SortJuniors[i].RankString());
            }
            jfile.Close();

            System.IO.StreamWriter sfile = new System.IO.StreamWriter("C:\\Users\\Patrick\\Desktop\\test data\\sfile.txt");
            string sline = "ANNUAL NORTHERN MINNESOTA MATHEMATICS CONTEST\n" + date + "\n\nDepartment of Mathematics and Computer Science\nBemidji State University\n\nSenior Dividion\n\nINDIVIDUAL RESULTS (INCLUDING TIEBREAKERS)\n\nRank  Score";
            sfile.WriteLine(sline + "\n");
            for (int i = 0; i < SortSeniors.Count(); i++)
            {
                sfile.WriteLine((i+1).ToString() + ".  " + SortSeniors[i].RankString());
            }
            sfile.Close();
        }
    }
}
