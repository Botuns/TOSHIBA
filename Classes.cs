using System;
namespace SUND_ASS
{
    public class Classes
    {
        public bool IsLeapYear()//Question one
        {
            Console.Write("Enter a year to know if it is a Leap Year: ");
            int year = int.Parse(Console.ReadLine());
            if(year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RandomNum()//Question two
        {
            Random random = new Random();
            

            for (int i = 1; i <= 10; i++)
            {
                int numbers = random.Next(200,300);
                Console.WriteLine(numbers);
            }
            
        }
        public void WeekDay()//Question three
        {
            var day = DateTime.Now.DayOfWeek;
            Console.WriteLine(day);
        }
        public void ComputerDayCount()//Question four
        {
            var counts = Environment.TickCount;
            Console.WriteLine(counts);
        }
        public void Hypotenuse()//Question five
        {
            Console.WriteLine("Enter lenght a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter lenght b: ");
            int b = int.Parse(Console.ReadLine());
            double hpy = Convert.ToDouble(Math.Sqrt((a^2) + (b^2)));
            Console.WriteLine(hpy);

        }
        public void TriArea()//Question six
        {
            Console.Write("Enter lenght a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter lenght b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter included angle y: ");
            double y = double.Parse(Console.ReadLine());
            double area = (a*b*Math.Asin(y))/2;
            Console.WriteLine($"Area = {area}");
        }
        public void Dates()//Question 9
        {
            Console.Write("Enter the date: ");
            DateTime anotherDate = DateTime.Parse(Console.ReadLine());

            double counts = (anotherDate - DateTime.Today).TotalDays;
            Console.WriteLine($"The total days are {counts}");
            Console.Write("Enter the number of weekends in the days: ");
            double weekends = double.Parse(Console.ReadLine());

            double finalCounts = counts-weekends;
            Console.WriteLine($"Final Days count = {finalCounts}");
        }
        public void Cls10()
        {
            int result = 0;
            Console.Write("Enter numbers: ");
            string inputNumbers = Console.ReadLine();
            string[] splitNumbers = inputNumbers.Split(' ');            

            for (int i = 0; i < splitNumbers.Length; i++)
            {
                result += Convert.ToInt32(splitNumbers[i]);

                Console.WriteLine("Result is: {0}", result);
            }
        }
        public void Cls11()
        {
            Random rnd = new Random();
            string[] firstNames = new string[] { "Diana", "Petia", "Stela", "Elena", "Katia" };
            string[] secondNames = new string[] { "Ivanova", "Petrova", "Kirova", "Popova" };
            string[] cities = new string[] { "Sofia", "Plovdiv", "Varna", "Ruse", "Dolno konare" };
            string[] reviews1 = new string[] { "This product is excelent.", "This is a great product.", "I use this product all the time.", "This is the best product of this category." };
            string[] reviews2 = new string[] { "Now I feel better.", "I changed.", "It was a miracle.", "I can't believe it. Now I feel better.", "Try it yourself. I'm very greatful." };

            Console.WriteLine("{0} {1}\n-- {2} {3}, {4}.", reviews1[rnd.Next(4)], reviews2[rnd.Next(5)], firstNames[rnd.Next(5)], secondNames[rnd.Next(4)], cities[rnd.Next(5)]);
        }
        public void Cls12()
        {
            
        }
        

    }
}