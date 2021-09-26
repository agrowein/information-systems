using System;

//? Таск 3, Вариант 3 
// TODO: Создать объект Самолет, используя классы Крыло, Шасси, Двигатель.
// Методы: летать, задавать маршрут, вывести маршрут.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane flexAir = new Airplane(
                "Flex 747",
                new Engine("Вертлявый-HW12"),
                new Chassis("Ролики-231"),
                new Wings("Икар-1504") 
            );

            System.Console.WriteLine(flexAir);

            try {
                flexAir.Fly();
            } catch (System.Exception e) {
                Console.WriteLine(e.ToString()); 
            }
            
            flexAir.SetRoute("Домодедово");
            System.Console.WriteLine(flexAir);

            System.Console.WriteLine(flexAir.ViewRoute());
            flexAir.Fly();
            System.Console.WriteLine(flexAir);
        }
    }
}
