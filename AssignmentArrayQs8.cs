namespace AssignmentString8
{
    internal class AssignmentArrayQs8
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter the number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the number of columns: ");
                int columns = Convert.ToInt32(Console.ReadLine());

                // Initialize matrices
                int[,] matrix1 = new int[rows, columns];
                int[,] matrix2 = new int[rows, columns];
                int[,] result = new int[rows, columns];

                Console.WriteLine("\nEnter elements for the first matrix:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nEnter elements for the second matrix:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Perform addition
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                // Display result
                Console.WriteLine("\nThe resulting matrix after addition is:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{result[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    
}
