using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Infrastructure.Abstractions;
using Logic.Infrastructure.Basis;
using Logic.Infrastructure.EnumTypes;

namespace Logic.Implementation.Figures;

public class Rook : Figure, IFigure
{
    public Rook(
        ColorType myColorType,
        DirectionType myDirectionType,
        Point startPosition)
        : base(FigureType.Rook, myColorType, myDirectionType, startPosition)
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