using System;
namespace SUND_ASS
{
    public class Student
    {
        string FullName;
        string Course;
        string Subject;
        string University;
        string Email;
        string PhoneNumber;
        static string[]NoOfObjects = new string[100];
       public int _noOfStudents = 0;

        public Student (string fullname ,string course,string subject, string university, string email, string phonenumber)
        {
            FullName = fullname;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phonenumber;
        }
        public Student()
        {

        }
         public Student (string fullname,string email, string phonenumber)
        {
            FullName = fullname;
            Email = email;
            PhoneNumber = phonenumber;
        }
        //  public Student (string course,string subject, string university)
        // {
            
        //     Course = course;
        //     Subject = subject;
        //     University = university;
        // }
        public void DisplayStudentDetail()
        {
            Console.Write("Enter your full name: ");
            string fullname = Console.ReadLine();
            Console.Write("Enter your course: ");
            string course = Console.ReadLine();
            Console.Write("Enter your subject: ");
            string subject = Console.ReadLine();
            Console.Write("Enter your university: ");
            string university = Console.ReadLine();
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string phonenumber = Console.ReadLine();

            Student student = new Student(fullname,course,subject,university,email,phonenumber);
            NoOfObjects[_noOfStudents] = student.ToString();
            _noOfStudents++;
            Console.WriteLine($"{student.FullName}\t{student.Course}\t{student.Subject}\t{student.University}\t{student.Email}\t{student.PhoneNumber}");

            
                
        }
    }
}