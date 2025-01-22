namespace AssignmentArray7
{
    internal class AssignmentArrayQs7
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]; // Array to hold elements
            int i, smallest, secondSmallest;

            Console.Write("\n\nFind the second smallest element in an array:\n");
            Console.Write("------------------------------------------------\n");

            Console.Write("Input 10 elements in the array:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write($"element - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in the array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write($"{arr[i]}  ");
            }

            Console.WriteLine();

            // Initialize smallest and second smallest
            if (arr[0] < arr[1])
            {
                smallest = arr[0];
                secondSmallest = arr[1];
            }
            else
            {
                smallest = arr[1];
                secondSmallest = arr[0];
            }

            // Iterate through the array to find the second smallest element
            for (i = 2; i < 10; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < secondSmallest && arr[i] != smallest)
                {
                    secondSmallest = arr[i];
                }
            }

            Console.WriteLine($"\nThe smallest element in the array is: {smallest}");
            Console.WriteLine($"The second smallest element in the array is: {secondSmallest}");
        }
    }
}
