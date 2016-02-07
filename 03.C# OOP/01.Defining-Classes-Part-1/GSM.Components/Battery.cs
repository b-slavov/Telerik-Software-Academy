namespace GSM.Components
{
    using System;
    using System.Text;

    // enumeration
    public enum BatteryType
    {
        Unknown, Li_Ion, Li_Pol, NiMH
    }

    public class Battery
    {
        // fields
        private int? standbyTime;
        private int? talkTime;

        // constructors
        public Battery()
            : this(null, null, null)
        {
        }

        public Battery(BatteryType? type, int? standbyTime, int? talkTime)
        {
            this.Type = type;
            this.StandbyTime = standbyTime;
            this.TalkTime = talkTime;
        }

        // automatic properties
        public BatteryType? Type { get; set; }

        // properties
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

        // methods
        public override string ToString()
        {
            StringBuilder batteryInformation = new StringBuilder();

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