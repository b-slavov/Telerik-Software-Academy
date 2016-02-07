namespace GSM.Components
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSMDevice
    {
        // private constants
        public static readonly GSMDevice IPhone4S = 
            new GSMDevice("Apple", "iPhone 4S", 800, null, new Battery(BatteryType.Li_Pol, 200, 14), new Display(3.5f, 16000000));

        // fields
        private string manufacturer;

        private string model;

        private decimal? price;

        private Battery battery;

        private Display display;

        private List<Call> callHistory = new List<Call>();

        // constructors
        public GSMDevice(string manufacturer, string model)
            : this(manufacturer, model, null, null, new Battery(), new Display())
        {

        }

        public GSMDevice(string manufacturer, string model, decimal? price, string owner, Battery gsmBattery, Display gsmDisplay)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.battery = gsmBattery;
            this.display = gsmDisplay;
        }

        // automatic properties
        public string Owner { get; set; }

        // properties
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Manufacturer can't be empty.");
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model can't be empty.");
                }

                this.model = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be negative.");
                }

                this.price = value;
            }
        }

        public string CallHistory
        {
            get
            {
                if (this.callHistory.Count == 0)
                {
                    return "No history available.";
                }
                else
                {
                    StringBuilder allCalls = new StringBuilder();

                    for (int i = 0; i < this.callHistory.Count; i++)
                    {
                        allCalls.AppendFormat("{0}. {1}\n", i + 1, this.callHistory[i]);
                    }

                    return allCalls.ToString().TrimEnd('\n');
                }
            }
        }

        // methods
        public string GetTotalPrice()
        {
            decimal totalPrice = 0m;

            foreach (Call call in this.callHistory)
            {
                totalPrice += (call.Duration / 60m) * Call.FixedPricePerMinute;
            }

            return totalPrice.ToString("C");
        }

        public override string ToString()
        {
            StringBuilder allInformation = new StringBuilder();

            allInformation.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
            allInformation.AppendFormat("Model: {0}\n", this.model);

            if (this.price != null)
            {
                allInformation.AppendFormat("Price: {0:C2}\n", this.price);
            }

            if (this.Owner != null)
            {
                allInformation.AppendFormat("Owner: {0}\n", this.Owner);
            }

            allInformation.AppendFormat("Battery: {0}\n", this.battery);
            allInformation.AppendFormat("Display: {0}\n", this.display);

            return allInformation.ToString();
        }

        public void AddCall(DateTime date, string dialedNumber, int duration)
        {
            this.callHistory.Add(new Call(date, dialedNumber, duration));
        }

        public void DeleteCall(int callNumber)
        {
            if (callNumber > this.callHistory.Count)
            {
                throw new ArgumentException("There isn't such call.");
            }

            this.callHistory.RemoveAt(callNumber - 1);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void RemoveLongestCall()
        {
            int maxDurationIndex = 0;
            int maxDuration = 0;

            if (this.callHistory.Count > 0)
            {
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    if (this.callHistory[i].Duration > maxDuration)
                    {
                        maxDuration = this.callHistory[i].Duration;
                        maxDurationIndex = i;
                    }
                }

                this.callHistory.RemoveAt(maxDurationIndex);
            }
            else
            {
                Console.WriteLine("Call history is empty.");
            }
        }
    }
}
