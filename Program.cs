using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace SUND_ASS
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ExceptionHandling exceptionHandling = new ExceptionHandling();
            //  exceptionHandling.Sqrt();
            //  exceptionHandling.ReadNumber();
            //  exceptionHandling.Solution12();
            //  exceptionHandling.Solution();

             List<StudentLinq> studentlinq = new List<StudentLinq>()
        {
            new StudentLinq() {FirstName = "Olajide", LastName = "Kolade", Age = 18},
            new StudentLinq() {FirstName = "Alabi", LastName = "Tinuke", Age = 17},
            new StudentLinq() {FirstName = "Olojede", LastName = "korede", Age = 16},
            new StudentLinq() {FirstName = "Adewura", LastName = "tolani", Age = 11},

            
        };
        var sortedNames = 
        from sorts in studentlinq 
        orderby sorts.FirstName[0] , sorts.LastName[0] ascending
        select sorts;
        foreach (var sorts in sortedNames )
        {
            Console.WriteLine(sorts);
        }
        // string text = "nothing lives better than good characters";
        // string value = new Sentence("en-US", false).TextInfo.ToTitleCase(text);


            
            // Classes classes = new Classes();
            // classes.ComputerDayCount();
            // classes.Dates();
            // classes.Hypotenuse();
            // classes.IsLeapYear();
            // classes.RandomNum();
            // classes.WeekDay();
            // classes.TriArea();

            // Recursion recursion = new Recursion();
            // int[]a = new int [2];
            // recursion.Loops(a,1);
            // recursion.GetCombinations(a,1,2,3);

            // Student student = new Student();
            // student.DisplayStudentDetail();

            // Texts texts = new Texts();
            // texts.Thetext();

            // DicHashSets dicHashSets = new DicHashSets();
            // dicHashSets.DicOne(a,2,3);

        
        }
    }
}
