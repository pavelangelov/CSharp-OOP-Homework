namespace DefiningClasses.Models
{
    using System;

    public class Call
    {
        private DateTime date;
        private string time;
        private string dialedPhone;
        private int duration;

        public Call(DateTime date, string dialedPhone, int duration)
        {
            this.Date = date;
            this.Time = this.Date.ToShortTimeString();
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            private set
            {
                this.time = value;
            }
        }

        public string DialedPhone
        {
            get
            {
                return this.dialedPhone;
            }
            private set
            {
                this.dialedPhone = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                if (value > 0)
                {
                    this.duration = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Date: {0}, Time: {1}, Dialed Phone: {2}, Duration: {3}seconds",
                                this.Date.ToShortDateString(), this.Time, this.DialedPhone, this.Duration);
        }
    }
}
