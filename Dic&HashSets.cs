using System;
namespace SUND_ASS
{
    public class DicHashSets
    {
        public int DicOne(int[]arr, int n, int x )
        {

            int res = 0;
            int []arrs = {1, 2, 2, 2, 2, 3, 4, 7 ,8 ,8 };
            int o = arr.Length;
            int y = 2;
         
            for (int i = 0; i < o; i++)
            if (y == arr[i])
            {
                res++;
            
       
         
                Console.Write(DicOne(arr, o, y));
             
                
            }
            return res;
            
        }
    }
}