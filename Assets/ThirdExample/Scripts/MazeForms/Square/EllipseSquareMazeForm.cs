using System.Collections.Generic;
using UnityEngine;

public class EllipseSquareMazeForm : MazeGridForm
{
    public override List<Vector2Int> GenerateGridCoordinates(int numberOfCells)
    {
        Debug.Log("—генерирована кругла€ сетка из квадратных тайлов");
        return null;
    }
}
