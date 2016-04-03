using System;


namespace Age
{
    class Age
    {
        static void Main()
        {
            String userInput = Console.ReadLine();
            DateTime localDate = DateTime.Now;
            DateTime yourbirthday = DateTime.Parse(userInput);
            int age = localDate.Year - yourbirthday.Year;
            if (localDate < yourbirthday.AddYears(age)) age--;
            Console.WriteLine(age);
            Console.WriteLine(age+10);
        }
    }
}
