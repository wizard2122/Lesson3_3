using System.Collections.Generic;
using UnityEngine;

public class TriangleSquareMazeForm : MazeGridForm
{
    public override List<Vector2Int> GenerateGridCoordinates(int numberOfCells)
    {
        Debug.Log("—генерирована треугольна€ сетка из квадратных тайлов");
        return null;
    }
}
