namespace DefiningClasses.Models
{
    using System;

    enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }
        

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                model = value;
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (value > 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException("Hours Idle must be greater than 0!");
                }
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException("Hours Talk must be greater than 0!");
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Model: {0}\r\nHours Idle: {1}\r\nHours Talk: {2}\r\nBattery Type: {3}",
                                    this.Model, this.HoursIdle, this.HoursTalk, this.BatteryType);
        }
    }
}
