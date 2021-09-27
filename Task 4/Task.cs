using System;

// TODO: Таск 4 Вариант 15
// 1 класс Автомобиль(марка, мощность двигателя, число мест) Q = 0.1 * мощность * число мест
// 2 класс Автомобиль(...) + P = год выпуска. Qp = Q - 1.5* (Текущий год - год выпуска)

namespace Task_4
{
    class Task
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mazda", 300, 5);
            CarWithAge car2 = new CarWithAge("Lada", 250, 5, 2016);
            CarWithAge car3 = new CarWithAge("BMW", 150, 6, 2019);

            Console.WriteLine(car + "\n");
            Console.WriteLine(car2 + "\n");
            Console.WriteLine(car3 + "\n");

            Console.WriteLine(car.Q());
            Console.WriteLine(car2.Q()); 
        }
    }
}
