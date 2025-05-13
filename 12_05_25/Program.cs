using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_25
{
    internal class Program
    {
        static List<int> inputList (string[] args , List<int> numbers1)
        {
            foreach (var number in args)
            {
                if (args.Count()>= 3)
                {
                    if (int.TryParse(number, out int realNumber))
                    {
                        if (realNumber > 0)
                        {
                            numbers1.Add(realNumber);
                        }
                    }
                }
                else
                {
                    handInput(numbers1);
                }
            }
          
            return numbers1;
        }

        static List<int> handInput(List<int> numbers1)
        {
            numbers1.Clear();
            string input = Console.ReadLine();
            string[] diferent_numbers = input.Split(' ');

            return inputList(diferent_numbers, numbers1);

        }

        static void enterPrint(List<int> list)
        {
            foreach (int num in list)
                Console.WriteLine(num);
        }
        static void exitPrint(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
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

            Console.WriteLine(sum / list.Count);
        }
        static void lenPrint(List<int> list)
        {
            Console.WriteLine(list.Count);
        }
        static void sumPrint(List<int> list)
        {
            int sumi = 0;
            foreach (int num in list)
                sumi += num;
            Console.WriteLine(sumi);
        }

      





        static void menu(List<int> list)
        {
            while (true)
            {
                Console.WriteLine(@"
                Please choose a number
                1 Input a Series.
                2 Display the series in the order it was entered.
                3 Display the series in the reversed order it was entered.
                4 Display the series in sorted order (from low to high).
                5 Display the Max value of the series.
                6 Display the Min value of the series.
                7 Display the Average of the series.
                8 Display the Number of elements in the series.
                9 Display the Number of elements in the series.
                10 Exit.");
                int answer =int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        handInput(list);
                        break;
                   case 2:
                        enterPrint(list);
                        break;
                   case 3:
                        exitPrint(list);
                        break;
                    case 4:
                        sortPrint(list);
                        break;
                    case 5:
                        maxPrint(list);
                        break;
                    case 6:
                        minPrint(list);
                        break;
                    case 7:
                        averPrint(list);
                        break;
                    case 8:
                        lenPrint(list);
                        break;
                    case 9:
                        sumPrint(list);
                        break;
                    case 10:
                        return;



                            
                }
            }
        }

        static void start(string[] args, List<int> numbers1)
        {
            inputList(args,numbers1);
            menu(numbers1);
        }





        static void Main(string[] args)
        {
            List<int> numbers1 = new List<int>();
            start(args, numbers1);

                //if(args)
            
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
