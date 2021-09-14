using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi
            //võrdleb sisestatud PIN-kood arvuga 1234
            //kui sisestatud PIN-koodi on 1234,
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis "Vale PIN. Proovi uuesti"

            Console.WriteLine("Palun sisesta PIN-kood.");
            int Number = Convert.ToInt32(Console.ReadLine());

            /*if (Number != 1234)  //!= ei võrdu
            {
                Console.WriteLine("Proovi uuesti!");
            }
            else
            {
                 Console.WriteLine("Tere tulemast!");
            }*/




        }
    }
}
