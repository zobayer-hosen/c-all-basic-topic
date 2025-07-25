using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practising_labib_vai_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];

            // int["this is the number of row","this is the number of coloum]

            arr[0,0] = 5;
            arr[0, 1] = 5;
            arr[0, 2] = 5;
            arr[0, 3] = 5;
            arr[1, 0] = 5;
            arr[1, 1] = 5;
            arr[1, 2] = 5;
            arr[1, 3] = 5;
            arr[2, 0] = 5;
            arr[2, 1] = 5;
            arr[2, 2] = 5;
            arr[2, 3] = 5;
            //int r = 0;
            // while( r<arr.GetLength(0))
            //{
            //    int j = 0;
            //    Console.Write("\n" + "[" + r + "]");
            //    while ( j <arr.GetLength(1))
            //    {
            //        Console.Write("  "+arr[r,j]);

            //        j++;
            //    }
            //    //Console.Write("\n"+"["+r+"]");

            //    r++;
            //}

            int[][] arr2 = new int[4][] { new int[5], new int[3], new int[2], new int[10] };

            arr2[0]= new int[3] { 1, 2, 3 };
            arr2[1] = new int[5] { 2, 3, 6,0,0 };
            arr2[2] = new int[2] { 3, 5 };

            Console.WriteLine("the jagged array");

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("\n[" + i + "]");
                for(int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j]);
                }
            }


           




        }
    }
}
