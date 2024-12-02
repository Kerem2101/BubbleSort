namespace BubbleSort
{
    internal class Program
    {
        static void Main()
        {
            // Initialisierung des Arrays
            int[] arr = { 4, 33, 7, 1, 23, 12 };

            // Bubblesort Algorithmus
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Tauschen der Werte
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Ausgabe des sortierten Arrays
            Console.WriteLine("Sortiertes Array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
