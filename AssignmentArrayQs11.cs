

namespace AssignmentString11
{
    class AssignmentArrayQs11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("\nEnter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element [{i + 1}]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Bubble sort logic
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1]) // Swap if the current element is greater than the next
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nThe sorted array is:");
            foreach (int element in arr)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
