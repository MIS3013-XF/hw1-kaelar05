// HW1b Grade

// Your Name: Mikaela Richard
// Did you seek help ? If yes, specify the helper or web link here: No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create variables to contain inputs

            string firstname;
            string lastname;
            string studentid;
            string AssignAsString;
            string Exam1AsString;
            string Exam2AsString;
            string Exam3AsString;
            string partgradeAsString;
            string partAsString;
            string quizAsString;

            double Assign;
            double Exam1;
            double Exam2;
            double Exam3;
            double partgrade;
            double part;
            double quiz;


            const double Assign_mult = .2;
            const double Exam1_mult = .15;
            const double Exam2_mult = .25;
            const double Exam3_mult = .25;
            const double partgrade_mult = .15;
            const double part_mult = 0;
            const double quiz_mult = 0;

            double assigntot;
            double exam1tot;
            double exam2tot;
            double exam3tot;
            double partgrade_tot;
            double part_tot;
            double quiz_tot;
            double finalgrade;
            double finalgrade2;

            //ask user questions
            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            studentid = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for assignments?");
            AssignAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            Exam1AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            Exam2AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 3?");
            Exam3AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for participation grade?");
            partgradeAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for participation?");
            partAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quizAsString = Console.ReadLine();

            //convert answers to doubles
            Assign = Convert.ToDouble(AssignAsString);
            Exam1 = Convert.ToDouble(Exam1AsString);
            Exam2 = Convert.ToDouble(Exam2AsString);
            Exam3 = Convert.ToDouble(Exam3AsString);
            partgrade = Convert.ToDouble(partgradeAsString);
            part = Convert.ToDouble(partAsString);
            quiz = Convert.ToDouble(quizAsString);

            //do the math

            assigntot = Assign * Assign_mult;
            exam1tot = Exam1 * Exam1_mult;
            exam2tot = Exam2 * Exam2_mult;
            exam3tot = Exam3 * Exam3_mult;
            partgrade_tot = partgrade * partgrade_mult;
            part_tot = part * part_mult;
            quiz_tot = quiz * quiz_mult;

            finalgrade = assigntot + exam1tot + exam2tot + exam3tot + partgrade_tot + part_tot + quiz_tot;
            finalgrade2 = finalgrade * .01;

            //give user the answer

            Console.WriteLine(firstname + " " + lastname + " " + "(" + studentid + ")," + " " + "your final grade is" + " " + finalgrade2.ToString("P2"));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            

        }
    }
}
