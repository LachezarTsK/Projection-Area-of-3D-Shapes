
package main

import "fmt"

func projectionArea(squareMatrix [][]int) int {
    sideLength := len(squareMatrix)
    totalProjectedArea := 0

    for row := 0; row < sideLength; row++ {
        var maxColumnHeight = 0
        var maxRowHeight = 0

        for column := 0; column < sideLength; column++ {
            if squareMatrix[row][column] > 0 {
                totalProjectedArea++
            }
            if maxRowHeight < squareMatrix[row][column] {
                maxRowHeight = squareMatrix[row][column]
            }
            if maxColumnHeight < squareMatrix[column][row] {
                maxColumnHeight = squareMatrix[column][row]
            }
        }
        totalProjectedArea += maxRowHeight + maxColumnHeight
    }

    return totalProjectedArea
}
