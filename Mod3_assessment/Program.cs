using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetCourseInformation();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Method not yet implemented");
            }
        }
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate: ");
            string bday = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, bday);
}

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthdate: ");
            string bday = Console.ReadLine();

        }
        static void PrintTeacherInformation(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
        static void GetCourseInformation()
        {
            throw new NotImplementedException();
        }
        static void PrintCourseInformation()
        {
            throw new NotImplementedException();
        }
        static void GetProgramInformation()
        {
            throw new NotImplementedException();
        }
        static void PrintProgramInformation()
        {
            throw new NotImplementedException();
        }
        static void GetDegreeInformation()
        {
            throw new NotImplementedException();
        }
        static void PrintDegreeInformation()
        {
            throw new NotImplementedException();
        }
    }
}
