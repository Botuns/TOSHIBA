using System;
namespace SUND_ASS
{
    public class Recursion
    {
        public void Loops(int[] arr, int index)
        {
            Console.Write("Enter N: ");            
            int n = Int32.Parse(Console.ReadLine());
            int[] arrs = new int[n];
            if (index >= arr.Length)
            {
                foreach (int element in arr) Console.Write("{0} ", element);
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    
                }
            }
        }
        public void GetCombinations(int[] arr, int index, int start, int end)
        {
            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = Int32.Parse(Console.ReadLine());
            int[] arrs = new int[k];   
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("), ");
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    
                }
            }
             

        }
        public void Ex3()
        {

        }
        static string[] wordsArr;
        public void Ex4(int[] arrs, int index, int start, int end)
        {
             Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            wordsArr = new string[length];
            Console.WriteLine();
            for (int i = 0; i < wordsArr.Length; i++)
            {
                Console.Write("Enter {0} word: ", i + 1);
                wordsArr[i] = Console.ReadLine();
            }
            Console.Write("\nEnter K: ");
            int k = Int32.Parse(Console.ReadLine());
            int[] arr = new int[k];
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}", wordsArr[arr[i]]);
                    if (i != arr.Length - 1) Console.Write(" ");
                }
                Console.Write("), ");
            }
            else
            {
                for (int i = start; i < end; i++)
                {
                    arr[index] = i;
                    Ex4(arr, index + 1, i + 1, end);
                }
            }
        }
        static string[] strings, str;
        static int length;
        public void Ex5(int iter, int index, int k)
        {
            Console.Write("Enter words length: ");
            length = Int32.Parse(Console.ReadLine());

            strings = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} word: ", i + 1);
                strings[i] = Console.ReadLine();
            }

            for (int i = 0; i <= length; i++)
            {
                str = new string[length];
                
            }
            if (iter == k)
            {
                for (int i = 0; i < length; i++)
                    Console.WriteLine("({0})", str[i]);
                return;
            }

            for (int i = index; i < strings.Length; i++)
            {
                str[iter] = strings[i];
                Ex5(iter + 1, i + 1, k);
            }
        }
        public void Ex6()
        {
            
        }
        public void Ex7(int[] arrr, int index)
        {
            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++) arr[i] = i + 1;
            if (index == arr.Length)
            {
                Console.Write("{");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("}, ");
            }
            else
            {
                for (int i = index; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                    Ex7(arr, index + 1);
                    temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                }
            }
            
        }
        public void Ex8()
        {
            
        }
        public void Ex9()
        {
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for(int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter sum: ");
            int sum = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int first = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int second = arr[j];

                    if ((first + second) == sum)
                    {
                        Console.WriteLine("({0}, {1}) ", first, second);
                    }
                }
            }
            
        }
        public void Ex10()
        {
            
        }
        

        

        
        
        
        
    }
}