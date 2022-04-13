using System.Collections.Generic;
using Logic.Implementation.Figures;
using Logic.Infrastructure.Abstractions;
using Logic.Infrastructure.Basis;
using Logic.Infrastructure.EnumTypes;

namespace Logic.Implementation;

public class Board
{
    private const short BoardSize = 8;
    private const short MaxAmountFigures = 32;

    public IList<Point> Points { get; protected set; } = new List<Point>(BoardSize * BoardSize);
    public IList<Figure> Figures { get; protected set; } = new List<Figure>(MaxAmountFigures);

    public Board(GameOptions gameOptions)
    {
        SetPoints();
        SetFigures(ColorType.White, gameOptions.WhitePlayerDirectionType);
        SetFigures(ColorType.Black, gameOptions.BlackPlayerDirectionType);
    }

    private void SetPoints()
    {
        for (int y = 0; y < BoardSize; y++)
        {
            for (int x = 0; x < BoardSize; x++)
            {
                Points.Add(new Point(x, y));
            }
        }
    }

    private void SetFigures(ColorType colorType, DirectionType directionType)
    {
        for (int count = 1; count <= GameContract.PlayerContact.CountKings; count++)
        {
            Figures.Add(new King(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.King)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountQueens; count++)
        {
            Figures.Add(new Queen(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Queen)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountElephants; count++)
        {
            Figures.Add(new Elephant(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Elephant, figureNumber: count)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountHorses; count++)
        {
            Figures.Add(new Horse(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Horse, figureNumber: count)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountRooks; count++)
        {
            Figures.Add(new Rook(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Rook, figureNumber: count)));
        }

        for (int count = 1; count <= GameContract.PlayerContact.CountPawns; count++)
        {
            Figures.Add(new Pawn(
                myColorType: colorType,
                myDirectionType: directionType,
                startPosition: GameContract.PlayerContact.GetStartPosition(directionType, FigureType.Pawn, figureNumber: count)));
        }
    }
}