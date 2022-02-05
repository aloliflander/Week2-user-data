using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun siseta oma vanus.");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            int YearOfBirth = 2022 - UserAge;
            Console.WriteLine("Oled sündinud aastal " + YearOfBirth);

        }
    }
}
