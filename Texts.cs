using System;
using System.IO;

namespace SUND_ASS
{
    public class Texts
    {
        
     public static int count = 0;
    public static String[] olajide;
    

    public void Thetext()//question one
    {
        string file = "C:\\Users\\TOSHIBA\\source\\repos\\BLAZE BANK APP\\Files\\Customer.txt";
        
        using (StreamReader r = new StreamReader(file))
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                count++;
            }
        }
        using (StreamReader sr = new StreamReader(file))
        {
            int i = 0;
            olajide = new String[count];
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                olajide[i] = line;
                Console.WriteLine(olajide[i]);
                i++;
            }
        }
        while (true)
        {
            string input = Console.ReadLine();
            int chooseLine = Convert.ToInt32(input);
            try
            {
                Console.WriteLine(olajide[chooseLine]);
            }
            catch
            {
                Console.WriteLine("Error! Not a number or array index out of bounds");
            }
            Console.ReadLine();
        }
    }
}
    
}