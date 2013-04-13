using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LINQStudentSearch
{
    static void Main(string[] args)
    {
        //Input
        Console.WriteLine("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        StudentInfo[] listOfStudents = new StudentInfo[n];
        for (int i = 0; i < n; i++)
        {
            StudentInfo oneStudent = new StudentInfo();
            Console.Write("First name: ");
            oneStudent.firstName = Console.ReadLine();
            Console.Write("Second name: ");
            oneStudent.secondName = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            oneStudent.age = byte.Parse(Console.ReadLine());
            listOfStudents[i]=oneStudent;
        }
        //Query 1 - First name before Last
        var sortedList =
            from student in listOfStudents
            where student.firstName.CompareTo(student.secondName) == -1
            select student;
        Console.WriteLine("These students have such names");
        foreach (var student in sortedList)
        {
            Console.WriteLine("{0} {1}",student.firstName,student.secondName);
        }

        //Query 2 - Of age 18-24
        var youngStudents =
            from student in listOfStudents
            where student.age >= 18 && student.age <= 24
            select student;

        foreach (var student in youngStudents)
        {
            Console.WriteLine("{0} {1} is between 18 and 24 years old",student.firstName,student.secondName);
        }

        //Sort with lambda
        var lamdaSorted = listOfStudents.OrderBy(firstName => firstName.firstName).ThenBy(firstName => firstName.secondName);
        foreach (var stud in lamdaSorted)
        {
            Console.WriteLine("{0} {1} is sorted by first and last name with Lambda exp ",stud.firstName,stud.secondName);
        }

        //Sort with linq
        var linqSorted =
            from student in listOfStudents
            orderby student.firstName
            orderby student.secondName
            select student;
        foreach (var stud in lamdaSorted)
        {
            Console.WriteLine("{0} {1} is sorted by first and last name with LINQ  ", stud.firstName, stud.secondName);
        }
    }
}

