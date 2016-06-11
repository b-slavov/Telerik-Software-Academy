namespace GSM.Components
{
    using System;
    using System.Text;

    public class Call
    {
        public const decimal FixedPricePerMinute = 0.37m;

        public readonly string Date;

        public readonly string Time;

        public readonly string DialedNumber;

        public readonly int Duration;

        public Call(DateTime date, string dialedNumber, int duration)
        {
            this.Date = date.ToShortDateString();
            this.Time = date.ToString("HH:mm");
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public override string ToString()
        {
            var callInfo = new StringBuilder();

            callInfo.AppendFormat("{0,-10} at ", this.DialedNumber);
            callInfo.AppendFormat("{0} ", this.Time);
            callInfo.AppendFormat("{0} for ", this.Date);
            callInfo.AppendFormat("{0} seconds", this.Duration);               

            return callInfo.ToString();
        }
    }
}
