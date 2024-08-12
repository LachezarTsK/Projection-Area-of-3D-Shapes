
class Solution {

    fun projectionArea(squareMatrix: Array<IntArray>): Int {
        val sideLength = squareMatrix.size
        var totalProjectedArea = 0

        for (row in 0..<sideLength) {
            var maxColumnHeight = 0
            var maxRowHeight = 0

            for (column in 0..<sideLength) {
                if (squareMatrix[row][column] > 0) {
                    ++totalProjectedArea
                }
                if (maxRowHeight < squareMatrix[row][column]) {
                    maxRowHeight = squareMatrix[row][column]
                }
                if (maxColumnHeight < squareMatrix[column][row]) {
                    maxColumnHeight = squareMatrix[column][row]
                }
            }
            totalProjectedArea += maxRowHeight + maxColumnHeight
        }

        return totalProjectedArea
    }
}
