using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //arrayda elementler ardicildirmi
            int[] array = { 1, 2, 6, 4, 5 };
            bool isSequential = true; 

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1] + 1)
                {
                    isSequential = false; 
                    break;
                }
            }

            Console.WriteLine(isSequential);

            //array daxilinde max ve min ededin yerinin deyisdirilmesi

            int[] numbers = { 10, 45, 32, 89, 7 };

            int max = numbers[0], min = numbers[0];
            int maxIndex = 0, minIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max += numbers[i];
                    maxIndex = i;
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }


            numbers[maxIndex] = numbers[maxIndex] + numbers[minIndex];
            numbers[minIndex] = numbers[maxIndex] - numbers[minIndex];
            numbers[maxIndex] = numbers[maxIndex] - numbers[minIndex];


            //Anonim tipler
            #region
            var obj = new { Property1 = "value1", Property2 = "value2" };
            var person1 = new { Name = "nurlan", Age = 25 };
            var person2 = new { Name = "nurlan", Age = 30 };

            //readonly
            var person3 = new
            {
                Name = "filaneks",
                Age = 21,
                Adress = new
                {
                    no = 12,
                    city = "baku"

                }
            };

            #endregion


            //Arrayler
            //string[] cars = { "bmw", "audi", "mercedes", "opel" };
            //string[] cars2 = new string[4];

            //int[] arrays = {1,2,3,4, 5, 6, 7, 8, 9, 10 };

            //int[,] arrays4 = { { 1, 2, 3 }, { 3,4,5} };


            //anonim tipler beraberliyi
            //var person4 = new
            //{
            //    Name = "filaneks",
            //    Age = 21,
            //    Adress = new
            //    {
            //        no = 12,
            //        city = "baku"

            //    }
            //};

            //Console.WriteLine(person3.Adress.Equals(person4.Adress));


            //Console.WriteLine(person1.Name);
            //Console.WriteLine(person2.Age);


            //break
            //for(int i=0; i<10; i++)
            // {
            //     if(i == 4)
            //     {
            //         break;
            //     }
            //     Console.WriteLine(i);
            // }



        }






























        //Console.WriteLine(person1.Equals(person2));


        //var personDataType = person1.GetType();
        //Console.WriteLine(personDataType);

        //int x = 10;
        //var dataType = x.GetType();
        //Console.WriteLine(dataType);



























        //int number = Convert.ToInt32 (input);
        //Console.WriteLine($"edediniz: {number}");


        //   int number1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("eded daxil edin: ");
        //string input = Console.ReadLine();

        //if (int.TryParse(input, out int result))
        //{
        //    Console.WriteLine($"edediniz: {result}");
        //}
        //else
        //{
        //    Console.WriteLine("duzgun eded daxil edin");
        //}


        //tryparse
        //Arrays
        //Massivlerin novleri (tekolculu, coxolculu) kesik massivler-ozleri arasdiracaq
        //int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Console.WriteLine(arrays[0]);

        //int[,] arrays2 = { { 1, 2, 3 }, { 4, 5, 6 } };
        //Console.WriteLine(arrays2[0, 2]);

        ////yazilmasi
        //string[] cars = new string[4];
        //string[] cars2 = { "ksks", "kslks", "ssk", "dkjd" };


        //Console.WriteLine(cars2.Length);

        //for (int i = 0; i < 5; i++)
        //{
        //    if (i == 2)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);
        //}




        ////tryparse convert32 parse

        ////Console.WriteLine("eded daxil edin: ");
        ////string input = Console.ReadLine();
        ////int number = Convert.ToInt32(input);
        ////Console.WriteLine(number);


        ////Console.WriteLine("eded daxil edin: ");
        ////int number = Convert.ToInt32(Console.ReadLine());
        ////Console.WriteLine("eded daxil edin: ");
        ////int age = int.Parse(Console.ReadLine());


        ////Console.WriteLine("enter a number: ");
        ////string input = Console.ReadLine();

        //Console.WriteLine("eded daxil edin: ");
        //string input = Console.ReadLine();

        //bool result = int.TryParse(input, out int number);
        //Console.WriteLine(result);
        ////if(int.TryParse(input, out int result))
        ////{
        ////    Console.WriteLine($"edediniz: {result}");
        ////}
        ////else
        ////{
        ////    Console.WriteLine("duzgun eded daxil edin");
        ////}


        ////Console.WriteLine(sum);
    }
    }

