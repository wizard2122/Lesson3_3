using UnityEngine;

public class Maze : MonoBehaviour
{
    public void Build(MazeGridForm gridForm, int numberOfCells)
    {
        gridForm.GenerateGridCoordinates(numberOfCells);
    }
}
