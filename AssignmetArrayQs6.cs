namespace AssignmentArray6
{
    internal class AssignmentArrayQs6
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]; // Array to hold elements
            int i, pos;

            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

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

            Console.WriteLine("\n\nDelete an element from the array:");
            Console.Write("Enter the position of the element to delete (0-9): ");
            pos = Convert.ToInt32(Console.ReadLine());

            if (pos < 0 || pos >= 10)
            {
                Console.WriteLine("Invalid position! Please enter a position between 0 and 9.");
            }
            else
            {
                // Shift elements to the left to overwrite the element at the desired position
                for (i = pos; i < 9; i++)
                {
                    arr[i] = arr[i + 1];
                }

                Console.Write("\nArray after deleting the element: ");
                for (i = 0; i < 9; i++) // Print the array with one less element
                {
                    Console.Write($"{arr[i]}  ");
                }

                Console.WriteLine();
            }
        }
    }
}
