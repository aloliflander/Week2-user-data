using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutaja sünniaastat
            Console.WriteLine("Palun sisesta oma sünniaasta:");
            // programm arvutab kasutaja vanust
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2022 - YearOfBirth;
            // kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis "Oled liiga noor , et juhilube saada"
            if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju ünne! Nüüd sa saad juhilube taotleda.");
            }   }
    }
}
