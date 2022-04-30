using System;
using System.IO;
using System.Net;
using System.Web;
using System.Data;

namespace SUND_ASS
{
    public class ExceptionHandling
    {
        public void Sqrt()//Question seven
        {
            try
            {
                Console.Write("Enter a number to print it sqrt root: ");
                int a = int.Parse(Console.ReadLine());
                double sqrtA = Math.Sqrt(a);
                Console.WriteLine($"The square root is {sqrtA}");
            }
            catch(SystemException ex)
            {
                Console.WriteLine("Invalid Number");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
        public void ReadNumber()
        {
            Console.Write("Start: ");
            int start = Int32.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = Int32.Parse(Console.ReadLine());
            
            if (end <= start + 10)
                Console.WriteLine("Wrong input");
            else
                ReadNumber();
                int count = 1, number;

            do
            {
                Console.Write("Number{0}: ", count);
                number = Int32.Parse(Console.ReadLine());

                if (number >= end || number <= start)
                {
                    Console.WriteLine("Wrong input!");
                    break;
                }
                else
                    start = number;

                count++;
            } while (count < 11);
        
        

        }
        public void Solution()
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\TOSHIBA\\source\\repos\\BLAZE BANK APP\\Files\\Customer.txt"))
        
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public void Solution12()
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\TOSHIBA\\source\\repos\\BLAZE BANK APP\\Files\\Customer.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("The specified path is invalid!");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Invalid syntax!");
            }
        }
        // public void DownloadAns()
        // {
        //     WebClient Client = new WebClient();
        //     try 
        //     {
                
        //         Client.DownloadFile("http://introprogramming.info/wp-content/themes/introprograming_en/images/Intro-Csharp-Book-front-cover-big_en.png");

           
        //     }
        //     catch (ArgumentException ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //         Console.WriteLine("The address or fileName parameter is null!");
        //     }
        //     catch (WebException ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //         Console.WriteLine("Error! Possible causes:\n1. The URI formed by combining BaseAddress and address is invalid.\n2. filename is null or Empty.\n3. The file does not exist.\n4. An error occurred while downloading data.");
        //     }
        //     catch (NotSupportedException ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //         Console.WriteLine("The method has been called simultaneously on multiple threads.");
        //     }
        // }

        

    }


}