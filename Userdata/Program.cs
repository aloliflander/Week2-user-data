using System;

namespace Userdata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - yearofbirth;
            Console.WriteLine("Oled " + userAge + " aastat vana.");
            

        }
    }
}
