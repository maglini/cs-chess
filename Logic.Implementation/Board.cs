using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Logic.Implementation.Figures;
using Logic.Infrastructure.Abstractions;
using Logic.Infrastructure.Basis;
using Logic.Infrastructure.EnumTypes;

namespace Logic.Implementation;

public class Board
{
    private const short BoardSize = 8;

    public IList<Cell> Cells { get; protected set; }

    public Board(GameOptions gameOptions)
    {
        Cells = SetCells(gameOptions);
    }

    protected IList<Cell> SetCells(GameOptions gameOptions)
    {
        IList<Cell> cells = new List<Cell>(BoardSize * BoardSize);

        IEnumerable<Figure> boardFigures = 
            SetFigures(ColorType.White, gameOptions.WhitePlayerDirectionType)
            .Union(
                SetFigures(ColorType.Black, gameOptions.BlackPlayerDirectionType));

        foreach (Figure figure in boardFigures)
        {
            cells.Add(new Cell(figure.StartPosition, figure));
        }

        IList<Point> startFiguresPositions = boardFigures.Select(f => f.StartPosition).ToList();

        for (int y = 0; y < BoardSize; y++)
        {
            for (int x = 0; x < BoardSize; x++)
            {
                if ( !(startFiguresPositions.Any(p => y == p.Y) && startFiguresPositions.Any(p => x == p.X)) )
                {
                    cells.Add(new Cell(new Point(x,y), null));
                }
            }
        }

        
        return cells;
    }

    protected IList<Figure> SetFigures(ColorType colorType, DirectionType directionType)
    {
        IList<Figure> figures = new List<Figure>();

        for (int count = 1; count <= GameContract.PlayerContact.CountKings; count++)
        {
            figures.Add(new King(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.King)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountQueens; count++)
        {
            figures.Add(new Queen(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Queen)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountElephants; count++)
        {
            figures.Add(new Elephant(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Elephant, figureNumber: count)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountHorses; count++)
        {
            figures.Add(new Horse(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Horse, figureNumber: count)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountRooks; count++)
        {
            figures.Add(new Rook(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Rook, figureNumber: count)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountPawns; count++)
        {
            figures.Add(new Pawn(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Pawn, figureNumber: count)));
        }

        return figures;
    }
}