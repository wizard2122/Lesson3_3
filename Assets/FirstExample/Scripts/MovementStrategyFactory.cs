using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MovementStrategyFactory
{
    private Transform _target;
    private List<Transform> _patrolPoints;

    public MovementStrategyFactory(Transform target, List<Transform> patrolPoints)
    {
        _target = target;
        _patrolPoints = new List<Transform>(patrolPoints);
    }

    public IMover Get(MoverTypes moverType, IMovable movable)
    {
        switch (moverType)
        {
            case MoverTypes.NoMove:
                return new NoMovePattern();

            case MoverTypes.PointByPoint:
                return new PointByPointMover(movable, _patrolPoints.Select(point => point.position));

            case MoverTypes.TargetFollower:
                return new MoveToTargetPattern(movable, _target);

            default:
                throw new ArgumentException(nameof(moverType));
        }
    }
}
