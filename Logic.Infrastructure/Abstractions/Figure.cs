using System.Collections.Generic;
using Logic.Infrastructure.Basis;
using Logic.Infrastructure.EnumTypes;

namespace Logic.Infrastructure.Abstractions;

public abstract class Figure : IFigure
{
    public FigureType FigureType { get; protected set; }

    public ColorType MyColorType { get; protected set; }
    public ColorType EnemyColorType => MyColorType == ColorType.White ? ColorType.Black : ColorType.White;

    public DirectionType MyDirectionType { get; protected set; }
    public DirectionType EnemyDirectionType => MyDirectionType == DirectionType.Top ? DirectionType.Bottom : DirectionType.Top;

    public Point Position { get; protected set; }
    public Point StartPosition { get; protected set; }

    protected Figure(
        FigureType figureType,
        ColorType myColorType,
        DirectionType myDirectionType,
        Point startPosition)
    {
        FigureType = figureType;
        MyColorType = myColorType;
        MyDirectionType = myDirectionType;
        StartPosition = startPosition;
        Position = startPosition;
    }

    public abstract IEnumerable<Point> GetSteps();
    public abstract IEnumerable<Point> GetStepsGradually();


}