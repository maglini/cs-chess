using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Infrastructure.Abstractions;

namespace Logic.Infrastructure.Basis;

public class Cell
{
    public Point Point { get; protected set; }
    public IFigure Figure { get; protected set; }

    public bool IsBusy => Figure != null;
    public bool IsEmpty => Figure != null;
    //public static bool IsPossibleStep(Point)
    //public static bool IsPossibleAttack()
    public Cell(Point point, IFigure figure)
    {
        Point = point;
        Figure = figure;
    }
}

