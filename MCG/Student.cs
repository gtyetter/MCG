using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG
{
    class Student
    {
private
        //classy is Junior or Senior
        //Name is self explanatory
        //level is AA or A
        //schoolCode determines where they attend
        //school is the string representation of their school
        //Answers are the students answers
        //score is their score with tiebreakers
        string classy;
        string LastName;
        string FirstName;
        string MiddleInitial;
        string level;
        int schoolCode;
        string school;
        string Answers;
        int score;

public
        //Constructor
        Student(string classLevel, string LN, string FN, string MI, int code1, int schCode, string answers)
        {
            classy = classLevel;
            LastName = LN;
            FirstName = FN;
            MiddleInitial = MI;
            schoolCode = schCode;
            Answers = answers;
            if (code1 == 41) { level = "AA"; }
            else { level = " A"; }
        }

        //Destructor
        ~Student()
        {

        }

        //Passes in the respective keys and finds the grade for that student
        void gradeIt(string answerKey, string tieBreaker)
        {
            
        }

        #region MinorDetails
        //Changes the school name string value
        void updateSchoolName(string theName)
        {
            school = theName;
        }

        #region ReturnThings
        //Returns the name.
        string returnName()
        {
            string it;
            it = LastName + " ," + FirstName + " " + MiddleInitial;
            return it;
        }

        //Returns score
        int returnScore()
        {
            return score;
        }

        //Returns Class
        string returnClass()
        {
            return classy;
        }

        //Returns AA or A
        string returnLevel()
        {
            return level;
        }

        //Returns school code
        int returnSchoolCode()
        {
            return schoolCode;
        }

        //Returns school name
        string returnSchool()
        {
            return school;
        }

        //Returns the students answers
        string returnAnswers()
        {
            return Answers;
        }
        #endregion ReturnThings
        #endregion MinorDetails
    }
}
