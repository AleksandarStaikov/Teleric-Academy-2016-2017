using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = Console.ReadLine();
            string address = Console.ReadLine();
            string companyTel = Console.ReadLine();
            string fax = Console.ReadLine();
            string site = Console.ReadLine();
            string fName = Console.ReadLine();
            string lname = Console.ReadLine();
            string age = Console.ReadLine();
            string personTel = Console.ReadLine();

            if (fax == "")
            {
                fax = "(no fax)";
            }
            Console.WriteLine(company);
            Console.WriteLine("Address: {0}",address);
            Console.WriteLine("Tel. {0}",companyTel);
            Console.WriteLine("Fax: {0}", fax);
            Console.WriteLine("Web site: {0}", site);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",fName, lname, age, personTel);
             
        }
    }
}
