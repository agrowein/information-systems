using System;

namespace Task_2
{
    class Program
    {
        //      Вариант 42. Дан тесктовый файл, каждая строка 
        //  которого изображает целое число, дополненное слева и
        //  справа несколькими пробелами. 
        //  TODO Вывести сумму этих числе и их количество

        static void Main(string[] args)
        {
            FileWorker fw1 = new FileWorker("./test4.txt");
            var res1 = fw1.ReduceLines();

            Console.WriteLine("Сумма чисел в строках: " + res1.Accomulator + "\n" + "Количество чисел: " + res1.Count);
        }
    }
}
