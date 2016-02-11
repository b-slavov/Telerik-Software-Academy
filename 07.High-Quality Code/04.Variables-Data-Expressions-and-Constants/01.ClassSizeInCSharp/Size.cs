namespace VariablesDataExpressionsAndConstantsHomeworkTaskOne
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; } 
            private set { this.height = value; }
        }

        public static Size GetRotatedSize(Size objectToRotate, double rotationAngle)
        {
            double rotationAngleCos = Math.Cos(rotationAngle);
            double rotationAngleSin = Math.Sin(rotationAngle);
            double rotationCosAbs = Math.Abs(rotationAngleCos);
            double rotationSinAbs = Math.Abs(rotationAngleSin);

            double width = (rotationCosAbs * objectToRotate.width) + (rotationSinAbs * objectToRotate.height);
            double height = (rotationSinAbs * objectToRotate.width) + (rotationCosAbs * objectToRotate.height);
            return new Size(width, height);
        }
    }
}