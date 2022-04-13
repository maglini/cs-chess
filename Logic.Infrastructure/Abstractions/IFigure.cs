using System.Collections.Generic;
using Logic.Infrastructure.Basis;

namespace Logic.Infrastructure.Abstractions;

public interface IFigure
{
    IEnumerable<Point> GetSteps();
    IEnumerable<Point> GetStepsGradually();
}