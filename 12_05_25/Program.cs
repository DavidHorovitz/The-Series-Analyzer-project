using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_25
{
    internal class Program

        

    {
        static  void  enterPrint(List<int> list)
        {
           foreach (int num in list) 
                Console.WriteLine(num);
        }
        static void exitPrint(List<int> list)
        {
            for (int i = list.Count -1; i>= 0; i--)
                Console.WriteLine(list[i]);
        }
        static void sortPrint(List<int> list)
        {
            list.Sort();
            foreach (int num in list)
                Console.WriteLine(num);
        }
        static void maxPrint(List<int> list)
        {
            int max = list[0];

            foreach (int num in list)
            {
                if (num > max)
                {
                    max = num;
                }
                Console.WriteLine(max);
            }

        }
        static void minPrint(List<int> list)
        {
            int min = list[0];

            foreach (int num in list)
            {
                if (num < min)
                {
                    min = num;
                }
                Console.WriteLine(min);
            }
        }
        static void averPrint(List<int> list)
             { 
             int sum = 0;

             foreach (int num in list)

                 sum += num; 

             Console.WriteLine(sum/list.Count);
             }
        static void lenPrint(List<int> list)
        {
            Console.WriteLine(list.Count);
        }












            


        static void Main(string[] args)
        {
            
            //int num;
            //string str;
            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);
            //}


            //str = "hello";
            //if(true)
            //{
            //    int num2 = 5;

            //}
            //num = 10;
        }    
    }
}
