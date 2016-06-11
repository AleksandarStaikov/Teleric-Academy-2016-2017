using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Gsm
    {
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Display disp;
        private Battery bat;
        private List<Call> callHistory = new List<Call>(); 
        private static Gsm IPhone4 = new Gsm("Iphone ot ali express", "Apple bace");



        public Gsm(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public Gsm(string manufacturer, string model, Battery bat) : this(model, manufacturer)
        {
            this.bat = bat;
        }

        public Gsm(Display disp, Battery bat, string manufacturer, string model, string owner, int price)
        {
            this.bat = bat;
            this.disp = disp;
            this.manufacturer = manufacturer;
            this.model = model;
            this.owner = owner;
            this.price = price;
        }

        public Battery Bat
        {
            get { return bat; }
            set { bat = value; }
        }

        public Display Disp
        {
            get { return disp; }
            set { disp = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public static Gsm Phone4
        {
            get { return IPhone4; }
            set { IPhone4 = value; }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {3}", this.model,
                this.owner, this.price, this.manufacturer);
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveLastCall()
        {
            this.callHistory.RemoveAt(callHistory.Count - 1);
        }

        public void ClearCallHistoy()
        {
            this.callHistory.Clear();
        }

        public double CallsCost(double pricePerMinute)
        {
            int totalCallsDuration = callHistory.Sum(x => x.Time);
            return totalCallsDuration * pricePerMinute;
        }
    }
}
