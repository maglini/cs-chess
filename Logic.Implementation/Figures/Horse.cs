using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Infrastructure.Abstractions;
using Logic.Infrastructure.Basis;
using Logic.Infrastructure.EnumTypes;

namespace Logic.Implementation.Figures;

public class Horse : Figure, IFigure
{
    public Horse(
        ColorType myColorType,
        DirectionType myDirectionType,
        Point startPosition)
        : base(FigureType.Horse, myColorType, myDirectionType, startPosition)
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
