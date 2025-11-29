using System;

namespace Day2.Libraries
{
    class SignalProcessor
    {
        public SignalProcessor() { }

        public double PowerToDecibel(double Power, double ReferencePower)
        {
            double right = Math.Log10(Power / ReferencePower);
            return 10 * right;
        }

        public double DecibelToPower(double Decibel, double ReferencePower)
        {
            double revRight = Math.Pow(10, Decibel / 10);
            return ReferencePower * revRight;
        }
    }
}
