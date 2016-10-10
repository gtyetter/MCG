using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG
{
    class Student
    {
        //classy is Junior or Senior
        //Name is self explanatory
        //level is AA or A
        //schoolCode determines where they attend
        //school is the string representation of their school
        //Answers are the students answers
        //score is their score with tiebreakers

        #region DefineVariables
        string rawLine;
        List<string> splitList;
        bool err = false;

        string classy;
        string LastName;
        string FirstName;
        string MiddleInitial;
        string level;
        string schoolCode;
        string school;
        string Answers;
        int score;
        #endregion DefineVariables

        #region Builds and Destroys

        //Constructor
        public Student(string classLevel, string line)
        {
            rawLine = line;
            classy = classLevel;
            validate();
        }

        //Destructor
        ~Student()
        {

        }

        #endregion Builds and Destroys

        #region Validation

        public void validate()
        {
            /*
            classy = classLevel;
            LastName = LN;
            FirstName = FN;
            MiddleInitial = MI;
            schoolCode = schCode;
            Answers = answers;
            if (code1 == "41") { level = "AA"; }
            else { level = " A"; }
            */
            splitList = killWhiteSpace(rawLine);
            if(splitList.Count()==5)
            {
                LastName = splitList[0];
                FirstName = splitList[1];
                MiddleInitial = " ";
                if (splitList[2] == "41") { level = "AA"; }
                else if (splitList[2] == "49") { level = " A"; }
                else 
                {
                    level = "UK";
                    err = true;
                }
                schoolCode = splitList[3];
                Answers = splitList[4];
                superEval();
            }
            else if(splitList.Count()==6)
            {
                LastName = splitList[0];
                FirstName = splitList[1];
                MiddleInitial = splitList[2];
                if (splitList[3] == "41") { level = "AA"; }
                else if (splitList[3] == "49") { level = " A"; }
                else
                {
                    level = "UK";
                    err = true;
                }
                schoolCode = splitList[4];
                Answers = splitList[5];
                superEval();
            }
            else
            {
                err = true;
            }
        }

        private void superEval()
        {
            if (LastName == "Student") { err = true; }
            if (FirstName == "Unknown") { err = true; }
            if (Answers.Count() != 40) { err = true; }
            if (schoolCode == "??????") { err = true; }
            for (int i = 0; i < Answers.Count();i++ )
            {
                if (Answers[i] != '1' || Answers[i] != '2' || Answers[i] != '3' || Answers[i] != '4' || Answers[i] != '5' || Answers[i] != '*')
                {
                    err = true;
                    break;
                }
            }
        }

        #endregion Validation

        //Passes in the respective keys and finds the grade for that student
        public void gradeIt(string answerKey, string tieBreaker)
        {
            score = 0;
            for(int i=0;i<40;i++)
            {
                if(Answers[i]==answerKey[i])
                {
                    score += 10000;
                    if (tieBreaker[i] == '1') { score += 100; }
                    else if (tieBreaker[i] == '2') { score += 1; }
                }
            }
        }

        //Changes the school name string value
        public void updateSchoolName(string theName)
        {
            school = theName;
        }

        #region Return Calls

        //Returns if there is an error
        public bool isErr()
        {
            return err;
        }

        //Returns the name.
        public string returnName()
        {
            string it;
            it = LastName + " ," + FirstName + " " + MiddleInitial;
            return it;
        }

        //Returns score
        public int returnScore()
        {
            return score;
        }

        //Returns Class
        public string returnClass()
        {
            return classy;
        }

        //Returns AA or A
        public string returnLevel()
        {
            return level;
        }

        //Returns school code
        public string returnSchoolCode()
        {
            return schoolCode;
        }

        //Returns school name
        public string returnSchool()
        {
            return school;
        }

        //Returns the students answers
        public string returnAnswers()
        {
            return Answers;
        }
        
        //Returns the validation string
        public string returnDebugString()
        {
            string it = "";
            if (isErr()) { it = it + "ERR "; }
            else { it = it + "OK  "; }

            it = it + returnName() + "\t\t" + returnClass() + " " + returnLevel() + " " + returnSchoolCode() + " " + returnAnswers();

            return it;
        }

        #endregion Return Calls

        //Parses the list removing all whitespace and leaving a list that is usable
        private List<string> killWhiteSpace(string it)
        {
            List<string> that = new List<string>();
            string blanko = "";
            for (int i = 0; i < it.Count(); i++)
            {
                if (it[i] != ' ' && it[i] != '\t')
                {
                    blanko = blanko + it[i];
                }
                else
                {
                    if (blanko.Count() != 0)
                    {
                        that.Add(blanko);
                        blanko = "";
                    }
                }
            }
            that.Add(blanko);
            return that;
        }

        #region Formatted Output

        public string RankString()
        {
            string it = "";

            it += returnScore() + "\t" + returnName() + "\t\t" + returnClass() + " " + returnLevel() + " " + returnSchool();

            return it;
        }

        public string SchoolGroupString()
        {
            string it = "";

            it += score.ToString() + "\t" + returnName();

            return it;
        }

        public string generalRankingString()
        {
            string it = "";

            it += score.ToString() + " " + returnName() + "\t\t" + returnClass() + " " + returnLevel() + " " + returnSchool() + "\t\t" + returnAnswers();

            return it;
        }
        
        #endregion Formatted Output
    }
}
