using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gd = new List<string>();

            gd.Add("d");
            gd.Add("a");
            gd.Add("q");
            gd.Add("f");
            gd.Add("e");
            gd = gd.OrderBy(x => x).ToList();
        }
    }
}
