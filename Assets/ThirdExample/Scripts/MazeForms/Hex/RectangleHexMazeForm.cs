using System.Collections.Generic;
using UnityEngine;

public class RectangleHexMazeForm : MazeGridForm
{
    public override List<Vector2Int> GenerateGridCoordinates(int numberOfCells)
    {
        Debug.Log("Сгенерирована прямоугольная сетка из шестиугольных тайлов");
        return null;
    }
}
