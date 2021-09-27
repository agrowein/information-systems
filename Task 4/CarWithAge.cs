using System;

namespace Task_4
{
    public class CarWithAge : Car
    {
        private int P;
        private int T = DateTime.Now.Year;

        public CarWithAge(string brand, double power, int places, int year)
            :base(brand, power, places) {
                this.P = year;
        }

        public override double Q() {
            return base.Q() - 1.5 * (this.T - this.P);
        }

        public override string ToString() {
            return base.ToString() + $"\nГод выпуска: {this.P}";
        }
    }
}