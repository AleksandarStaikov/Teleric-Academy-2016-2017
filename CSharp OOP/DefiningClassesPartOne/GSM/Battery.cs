using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Battery
    {
        private string model;
        private int hoursTalk;
        private int hoursIdle;
        private BatteryType type;

        public Battery(int hoursIdle, int hoursTalk, string model, BatteryType type)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.model = model;
            this.type = type;
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public BatteryType Type1
        {
            get { return type; }
            set { type = value; }
        }
    }
}
