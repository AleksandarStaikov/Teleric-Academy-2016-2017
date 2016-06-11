using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Display
    {
        private int size;
        private int numberOfColors;

        public Display(int size, int numberOfColors)
        {
            Size = size;
            NumberOfColors = numberOfColors;
        }

        public int NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
