namespace _006Multidimensional_Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[2, 2]
        {
            {1,2},
            {3,4}
        }; //Declaration and Direct Initialization of the MD array
        
        matrix[0, 0] = 0;// Updating the value of matrix[0,0] from 1 to 0
        
        int[,] loopMatrix = new int[2, 2];
        
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        //Loop way of Initialization of the array
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                loopMatrix[r, c] = matrix[r, c];//loop matrix and matrix have the same value
                Console.Write(loopMatrix[r, c] + " ");
            }
            Console.WriteLine();
        }
        
    }
    
}