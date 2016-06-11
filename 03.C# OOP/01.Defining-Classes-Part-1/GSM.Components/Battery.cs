namespace GSM.Components
{
    using System;
    using System.Text;

    public class Battery
    {
        private int? standbyTime;
        private int? talkTime;

        public Battery(BatteryType? type, int? standbyTime, int? talkTime)
        {
            this.Type = type;
            this.StandbyTime = standbyTime;
            this.TalkTime = talkTime;
        }

        public Battery()
            : this(null, null, null)
        {
        }

        public BatteryType? Type { get; set; }

        public int? StandbyTime
        {
            get 
            { 
                return this.standbyTime;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery's stand-by time can't be zero or negative.");
                }

                this.standbyTime = value;
            }
        }

        public int? TalkTime
        {
            get 
            {
                return this.talkTime;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery's talk time can't be zero or negative.");
                }

                this.talkTime = value;
            }
        }

        public override string ToString()
        {
            var batteryInformation = new StringBuilder();

            batteryInformation.AppendFormat("{0} ", this.Type ?? 0);

            if (this.standbyTime != null)
            {
                batteryInformation.AppendFormat(", Stand-by time: {0}h, ", this.standbyTime);                
            }

            if (this.talkTime != null)
            {
                batteryInformation.AppendFormat("Talk time: {0}h", this.talkTime);           
            }

            return batteryInformation.ToString();
        }
    }
}
