using System.Collections.Generic;
using UnityEngine;

public class TriangleHexMazeForm : MazeGridForm
{
    public override List<Vector2Int> GenerateGridCoordinates(int numberOfCells)
    {
        Debug.Log("—генерирована треугольна€ сетка из шестиугольных тайлов");
        return null;
    }
}
