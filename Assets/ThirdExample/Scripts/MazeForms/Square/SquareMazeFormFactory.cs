using System;

public class SquareMazeFormFactory : MazeFormFactory
{
    public override MazeGridForm Get(MazeFormType type)
    {
        switch (type)
        {
            case MazeFormType.Rectangle:
                return new RectangleSquareMazeForm();

            case MazeFormType.Ellipse:
                return new EllipseSquareMazeForm();

            case MazeFormType.Triangle:
                return new TriangleSquareMazeForm();

            default:
                throw new ArgumentException(nameof(type));
        }
    }
}
