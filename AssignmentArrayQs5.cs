namespace AssignmentArray5
{
    internal class AssignmentArrayQs5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11]; // Array size increased to accommodate the new value

            int i, j, newValue;

            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input 10 elements in the array in sorted order:\n");
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

            Console.WriteLine("\n\nInsert a new value in the array:");
            Console.Write("Enter the value to insert: ");
            newValue = Convert.ToInt32(Console.ReadLine());

            // Find the correct position to insert the new value
            for (i = 0; i < 10; i++)
            {
                if (arr[i] > newValue)
                    break;
            }

            // Shift elements to the right to make space for the new value
            for (j = 10; j > i; j--)
            {
                arr[j] = arr[j - 1];
            }

            // Insert the new value
            arr[i] = newValue;

            Console.Write("\nArray after inserting the new value: ");
            for (i = 0; i < 11; i++)
            {
                Console.Write($"{arr[i]}  ");
            }

            Console.WriteLine();
        }
    }
}
