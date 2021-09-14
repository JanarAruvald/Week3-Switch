using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");
            int Hinne = Convert.ToInt32(Console.ReadLine());


            switch(Hinne)
            {
                case 5:
                    Console.WriteLine("Suurepärane!");
                    break;
                case 4:
                    Console.WriteLine("Väga hea!");
                    break;
                case 3:
                    Console.WriteLine("Hea!");
                    break;
                case 2:
                    Console.WriteLine("Rahuldav!");
                    break;
                case 1:
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine("Kordad kursust!");
                    break;
            }

            Console.WriteLine("Kena päeva!");

            /*if (Hinne == 5)
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (Hinne == 4)
            {
                Console.WriteLine("Väga hea.");
            }
            else if (Hinne == 3)
            {
                Console.WriteLine("Hea.");
            }
            else if (Hinne == 2)
            {
                Console.WriteLine("Rahuldav.");
            }
            else if (Hinne == 1)
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Puudulik.");
            }*/

        }
    }
}
