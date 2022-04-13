using System;
using System.Collections.Generic;
using Logic.Infrastructure.Abstractions;
using Logic.Infrastructure.Basis;
using Logic.Infrastructure.EnumTypes;

namespace Logic.Implementation.Figures;

public class Pawn : Figure, IFigure
{
    public Pawn(
        ColorType myColorType,
        DirectionType myDirectionType,
        Point startPosition)
        : base(FigureType.Pawn, myColorType, myDirectionType, startPosition)
    {

    }

    public override IEnumerable<Point> GetSteps()
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<Point> GetStepsGradually()
    {
        throw new NotImplementedException();
    }
}