

namespace AssignmentArray2
{
    internal class AssignmentArrayQs2
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];  // Declaration of an integer array with size 10
            
            int i;

            // Display a message about reading and printing elements of an array
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------------------------------\n");

            Console.Write("Input 10 elements in the array :\n");  // Prompt user to input 10 elements

            // Loop to read 10 elements from the user and store them in the array
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);  // Prompt for input element number
                arr[i] = Convert.ToInt32(Console.ReadLine());  // Read user input and convert it to an integer, then store in the array
            }

            Console.Write("\nElements in array are: ");  // Display message before printing array elements

            // Loop to print the elements of the array
            for (i = 0; i < 10; i++)
            {
                Console.Write(" {0}  ", arr[i]);  // Print each element of the array
            }

            Console.Write("\n");  // Move to the next line for better readability

            //printing the maximum value
            Console.Write("------------------------------------------------------------------\n");
            Console.Write("\n\nPrinting the maximum value\n");
            int max = arr[0];
            for(int k = 0; k < 10; k++)
            {
                if (arr[k] > max)
                {
                    max = arr[k];
                }
            }
            Console.WriteLine($"The maximum value of the array is {max}");


            Console.Write("---------------------------------------------------------------------\n");
            Console.Write("\n\nPrinting the minimum value\n");
            int min = arr[0];
            for (int k = 0; k < 10; k++)
            {
                if (arr[k] < min)
                {
                    min = arr[k];
                }
            }
            Console.WriteLine($"The minimum value of the array is {min}");


        }



    }
}


