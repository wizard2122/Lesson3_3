using System.Collections.Generic;
using UnityEngine;

public class EllipseHexMazeForm : MazeGridForm
{
    public override List<Vector2Int> GenerateGridCoordinates(int numberOfCells)
    {
        Debug.Log("—генерирована кругла€ сетка из шестиугольных тайлов");
        return null;
    }
}
