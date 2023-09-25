using System;
using UnityEngine;

public class MazeExample : MonoBehaviour
{
    [SerializeField] private CellType _cellType;
    [SerializeField] private MazeFormType _formType;
    [SerializeField, Range(4, 100)] private int _numberOfCells;

    [SerializeField] private Maze _maze;

    [ContextMenu("BuildMenu")]
    public void BuildMaze()
    {
        MazeFormFactory factory;

        switch (_cellType)
        {
            case CellType.Square:
                factory = new SquareMazeFormFactory();
                break;

            case CellType.Hex:
                factory = new HexMazeFormFactory();
                break;

            default:
                throw new InvalidOperationException(nameof(_cellType));
        }

        _maze.Build(factory.Get(_formType), _numberOfCells);
    }
} 
