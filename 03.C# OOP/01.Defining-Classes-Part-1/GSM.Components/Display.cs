namespace GSM.Components
{
    using System;
    using System.Text;

    public class Display
    {
        private float? inches;

        private int? colors;

        public Display(float? inches, int? colors)
        {
            this.Inches = inches;
            this.Colors = colors;
        }

        public Display()
            : this(null, null)
        {
        }

        public float? Inches
        {
            get 
            {
                return this.inches;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display can't be zero or less inches.");
                }

                this.inches = value; 
            }
        }

        public int? Colors
        {
            get 
            {
                return this.colors;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display must be with 1 or more colors.");
                }

                this.colors = value; 
            }
        }

        public override string ToString()
        {
            var displayInformation = new StringBuilder();

            if (this.inches != null)
            {
                displayInformation.AppendFormat("{0:0.0}\", ", this.inches);
            }

            if (this.colors != null)
            {
                displayInformation.AppendFormat("{0} colors", this.colors);                
            }

            return displayInformation.Length != 0 ? displayInformation.ToString() : "Unknown";
        }
    }
}
