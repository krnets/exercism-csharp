public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        var matrix = new int[size, size];
        int counter = 1;
        int nSquared = size * size;
        int rowStart = 0, colStart = 0;
        int rowEnd = size - 1, colEnd = size - 1;

        while (counter <= nSquared)
        {
            for (int i = colStart; i <= colEnd; i++)
                matrix[rowStart, i] = counter++;
            
            rowStart++;

            for (int j = rowStart; j <= rowEnd; j++)
                matrix[j, colEnd] = counter++;
            
            colEnd--;

            for (int i = colEnd; i >= colStart; i--)
                matrix[rowEnd, i] = counter++;
            
            rowEnd--;

            for (int j = rowEnd; j >= rowStart; j--)
                matrix[j, colStart] = counter++;
            
            colStart++;
        }

        return matrix;
    }
}