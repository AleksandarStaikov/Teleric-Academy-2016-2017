using System;
namespace _15.Age
{
    class Program
    {
        static void Main()
        {
            string birthDateString = Console.ReadLine();
            int birthDay = int.Parse(birthDateString.Substring(3, 2));
            int birthMonth = int.Parse(birthDateString.Substring(0, 2));
            int birthYear = int.Parse(birthDateString.Substring(6, 4));

            DateTime currentTime = new DateTime();

            int result = DateTime.Now.Year - birthYear;

            if (DateTime.Now.Month == birthMonth)
            {
                if (DateTime.Now.Day < birthDay)
                {
                    result--;
                }
            }
            if (DateTime.Now.Month < birthMonth)
            {
                result--;
            }

            Console.WriteLine(result);
            Console.WriteLine(result + 10);
        }
    }
}
