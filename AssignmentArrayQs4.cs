namespace AssignmentString4
{
    internal class AssignmentArrayQs4
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter the number of elements in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Input the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element - {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sorting the array in descending order
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j]) // Compare for descending order
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nThe array sorted in descending order is:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
 }

