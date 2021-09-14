using System;

namespace InstagramAgeProtect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta oma sünniaasta.");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            if (YearOfBirth > 2008)
            {
                Console.WriteLine("Oled liiga noor, et konto luua.");
            }
            else if (YearOfBirth < 2008)
            {
                Console.WriteLine("Oled piisavalt vana, et konto luua.");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, et konto luua.");
            }

            
        }
    }
}
