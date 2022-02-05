using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta oma vanus");
            int userage = Convert.ToInt32(Console.ReadLine());
            if (userage > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            else if (userage < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            Console.WriteLine("Kena päeva.");
        
        }
    }
}
