

namespace AssignmentArray3
{
    internal class AssignmentArrayQs3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];  // Original array
            int[] arr1 = new int[10]; // Array to store even numbers
            int[] arr2 = new int[10]; // Array to store odd numbers

            int i;

            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input 10 elements in the array :\n");
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

            int j = 0; // Index for even numbers
            int h = 0; // Index for odd numbers
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] % 2 == 0)
                {
                    arr1[j] = arr[k]; // Store even number
                    j++;
                }
                else
                {
                    arr2[h] = arr[k]; // Store odd number
                    h++;
                }
            }

            // Display even elements
            Console.Write("\nThe Even elements are: ");
            for (int k = 0; k < j; k++) // Iterate up to `j`
            {
                Console.Write($"{arr1[k]} ");
            }

            // Display odd elements
            Console.Write("\nThe Odd elements are: ");
            for (int k = 0; k < h; k++) // Iterate up to `h`
            {
                Console.Write($"{arr2[k]} ");
            }
            Console.WriteLine();
        }
    }
}
