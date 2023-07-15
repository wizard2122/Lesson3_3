using System.Collections.Generic;
using UnityEngine;

public abstract class MazeGridForm
{
    public abstract List<Vector2Int> GenerateGridCoordinates(int numberOfCells);
}
