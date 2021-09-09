using System;
using System.Text;

namespace Task_1
{
    class Task
    {
        //TODO Вариант 13. Упорядочить строки матрицы A(m,n) по неубыванию их евклидовых норм.
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][] testArray = new int[100][];
            for (var i = 0; i < testArray.Length; i++) {
                testArray[i] = new int[10];
                for(var j = 0; j < testArray[i].Length; j++) {
                    testArray[i][j] = (int) rnd.Next(10);
                }
            }
            PrintArray2(testArray, "Исходный массив:");
            int[][] result = SortEuclidVectors(testArray);
            PrintArray2(result, "Результат:");
        }

        public static int[][] SortEuclidVectors(int[][] matrix) {
            if (matrix.Length <= 1) {
                return matrix;
            }

            
            for (var i = 1; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix.Length - 1; j++)
                {
                    if (EuclidNormal(matrix[j]) > EuclidNormal(matrix[j + 1]))
                    {
                        var temp = matrix[j];
                        matrix[j] = matrix[j + 1];
                        matrix[j + 1] = temp;
                    }
                    
                }
            }

            return matrix;
        }

        public static int EuclidNormal(int[] vector) {
            double summa = 0;
            for (var i = 0; i < vector.Length; i++) {
                summa += Math.Pow(vector[i], 2);
            }
            return (int) Math.Sqrt(summa);
        }

        public static void PrintArray2(int[][] array, string label) {
            StringBuilder sb = new StringBuilder();
            sb.Append(label + '\n');
            for (var i = 0; i < array.Length; i++) {
                for(var j = 0; j< array[i].Length; j++) {
                    sb.Append(array[i][j] + " ");
                }
                sb.Append("  normal: " + EuclidNormal(array[i]));
                sb.Append('\n');
            }
            Console.WriteLine(sb.ToString());
        }
    }    
}
