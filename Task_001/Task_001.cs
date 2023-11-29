using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_001
{
    public class Task_001
    {
        public const int COPACITY = 3;
        public const int MIN = 1;
        public const int MAX = 100;
        public static void Main(string[] args) {
            int[][] multiArray = GetMultiArrayWithRandomValue(COPACITY, COPACITY);

            System.Console.WriteLine("Оригинальный массив: ");
            PrintMultiArray(multiArray);

            System.Console.WriteLine("Четные элементы изменены на их квадраты: ");
            PrintMultiArray(PowEvenElementMultiArray(multiArray));

        }

        public static int[] GetArrayWithRandomValue(int size) {
            int[] array = new int[size];
            for(int i = 0; i < size; i++) {
                array[i] = new Random().Next(MIN, MAX);
            }
            return array;
        }

        public static int[][] GetMultiArrayWithRandomValue(int stringCount, int columnCount) {
            int[][] jaggedArray = new int[stringCount][];
            for(int i = 0; i < stringCount; i++) {
                jaggedArray[i] = GetArrayWithRandomValue(columnCount);
            }
            return jaggedArray;
        }

        public static string PrintArray(int[] array) {
            string result = "";
            foreach(int item in array) {
                result = result + item + " ";
            }
            return result;
        }

        public static void PrintMultiArray(int[][] array) {
            for(int i = 0; i < array.Length; i++) {
                System.Console.WriteLine(PrintArray(array[i]));
            }
        }

        public static int[][] PowEvenElementMultiArray(int[][] array) {
            for(int i = 0; i < array.Length; i++) {
                array[i] = PowEvenElement(array[i]);
            }
            return array;
        }

        public static int[] PowEvenElement(int[] array) {
            for(int i = 0; i < array.Length; i++) {
                if(array[i] % 2 == 0) {
                    array[i] *= array[i];
                }
            }
            return array;
        }
    }
}