
using System;

public class Solution
{
    public int ProjectionArea(int[][] squareMatrix)
    {
        int sideLength = squareMatrix.Length;
        int totalProjectedArea = 0;

        for (int row = 0; row < sideLength; ++row)
        {
            int maxColumnHeight = 0;
            int maxRowHeight = 0;

            for (int column = 0; column < sideLength; ++column)
            {
                if (squareMatrix[row][column] > 0)
                {
                    ++totalProjectedArea;
                }
                if (maxRowHeight < squareMatrix[row][column])
                {
                    maxRowHeight = squareMatrix[row][column];
                }
                if (maxColumnHeight < squareMatrix[column][row])
                {
                    maxColumnHeight = squareMatrix[column][row];
                }
            }
            totalProjectedArea += maxRowHeight + maxColumnHeight;
        }

        return totalProjectedArea;
    }
}
