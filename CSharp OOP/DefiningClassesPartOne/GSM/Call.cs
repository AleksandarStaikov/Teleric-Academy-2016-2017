using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Call
    {
        private string date;
        private int time;
        private string dieldPhone;

        public Call(string date, string dieldPhone, int time)
        {
            this.date = date;
            this.dieldPhone = dieldPhone;
            this.time = time;
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public string DieldPhone
        {
            get { return dieldPhone; }
            set { dieldPhone = value; }
        }
    }
}
