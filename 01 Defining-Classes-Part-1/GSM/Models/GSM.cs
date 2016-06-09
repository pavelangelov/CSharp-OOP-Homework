namespace DefiningClasses.Models
{
    using System;
    using System.Collections.Generic;

    class GSM
    {
        private static  GSM iphone4S = new GSM("iPhone4S", "Apple", 1000, "Steve Jobs", new Battery("A200", 500, 13, BatteryType.LiIon), new Display());
        private string model;
        private string manufacturer;
        private decimal? price = null;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer, decimal? price = null, string owner = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }
        
        public static GSM IPhone4S
        {
            get
            {
                return iphone4S;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value == null || (value.Length > 1 && value.Length < 15))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("The length of Model must be greather than 1 and less than 15 symbols!");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (value.Length > 2 && value.Length < 15)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("The value of Manufacturer must be greater than 2 and less tha 15 symbols!");
                }
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
                if (value == null || (value > 0 && value < 50000))
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The price must be greater than 0 and less tha 50000");
                }
                
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null || (value.Length > 1 && value.Length < 30))
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("The owner must contain more than 1 and less than 30 symbols!");
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Model: {0} \r\nManufacturer: {1} \r\nPrice: {2} $ \r\nDisplay: {3} \r\nBattery: {4} \r\nOwner: {5}", 
                                    this.Model, this.Manufacturer, this.Price, this.Display, this.Battery, this.Owner);
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveCall(int callNumber)
        {
            if (callNumber - 1 >= 0 || callNumber - 1 <= this.CallHistory.Count)
            {
                this.callHistory.RemoveAt(callNumber - 1);
            }
            else
            {
                throw new IndexOutOfRangeException("Call with this number doesn`t exist!");
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void ShowCallHistory()
        {
            Console.WriteLine("Number of calls: {0}", this.CallHistory.Count);

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, this.CallHistory[i]);
            }
        }

        public string CallsPrice(double pricePerMinute)
        {
            double result = 0;
            double callsDuration = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                Call currentCall = CallHistory[i];
                callsDuration += currentCall.Duration;
            }

            result = (callsDuration / 60) * pricePerMinute;

            return string.Format("Total price: {0:F2} $", result);
        }
    }
}
