using System;
namespace _06___Manual___Exercise_07___ARRAY {
    class Program {
        static void Main(string[] args) {

            int[] arr = new int[] { 7, 3, 5, 1, 9, 2 }; // ------> Elementos do ARRAY

            Console.WriteLine("Enter the number to search: "); 
            int num = int.Parse(Console.ReadLine()); // ----- > Elemeto a ser buscado no ARRAY

            bool found = false;
            for (int i =0; i < arr.Length; i++) {  // ----- > Condicional da busca 
                if (num == arr[i]) {
                    found = true;
                    break;
                }
            }
            if (found) {
                Console.WriteLine("Element found");
            }
            else {
                Console.WriteLine("Elemente not found");
            }

        }
    }
}
