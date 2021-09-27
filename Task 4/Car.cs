using System;

namespace Task_4
{
    public class Car
    {
        protected string brand;
        protected double power;
        protected int places;

        public Car(string brand, double power, int places) {
            if (places <= 0 || power < 0) {
                throw new System.Exception("Incorrect parameter values");
            }
            this.brand = brand;
            this.power = power;
            this.places = places;
        }

        public virtual double Q() {
            return 0.1 * this.power * this.places;
        }

        public override string ToString() {
            return $"Автомобиль \nмарка: {this.brand} \nмощность двигателя: {this.power} кВт \nколичество мест: {this.places}";
        }
    }
}