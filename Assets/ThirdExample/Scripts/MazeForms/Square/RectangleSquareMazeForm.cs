using System.Collections.Generic;
using UnityEngine;

public class RectangleSquareMazeForm : MazeGridForm
{
    public override List<Vector2Int> GenerateGridCoordinates(int numberOfCells)
    {
        Debug.Log("—генерирована пр€мугольна€ сетка из квадратных тайлов");
        return null;
    }
}
