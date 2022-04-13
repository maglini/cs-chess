using System;
using Logic.Utils.EnumTypes;

namespace Logic.Utils;

public static class GameContract
{
    public static class PlayerContact
    {
        public static int CountKings = 1;
        public static int CountQueens = 1;
        public static int CountRooks = 2;
        public static int CountElephants = 2;
        public static int CountHorses = 2;
        public static int CountPawns = 8;

        public static Point GetStartPosition(DirectionType directionType, FigureType figureType, int figureNumber = 0)
        {
            return figureType switch
            {
                FigureType.King when directionType == DirectionType.Top
                    => new Point(number: 8, character: 'e'),

                FigureType.King when directionType == DirectionType.Bottom
                    => new Point(number: 1, character: 'e'),

                FigureType.Queen when directionType == DirectionType.Top
                    => new Point(number: 8, character: 'd'),

                FigureType.Queen when directionType == DirectionType.Bottom
                    => new Point(number: 1, character: 'd'),

                FigureType.Elephant when directionType == DirectionType.Top && figureNumber == 1
                    => new Point(number: 8, character: 'c'),
                FigureType.Elephant when directionType == DirectionType.Top && figureNumber == 2
                    => new Point(number: 8, character: 'f'),

                FigureType.Elephant when directionType == DirectionType.Bottom && figureNumber == 1
                    => new Point(number: 1, character: 'c'),
                FigureType.Elephant when directionType == DirectionType.Bottom && figureNumber == 2
                    => new Point(number: 1, character: 'f'),

                FigureType.Horse when directionType == DirectionType.Top && figureNumber == 1
                    => new Point(number: 8, character: 'b'),
                FigureType.Horse when directionType == DirectionType.Top && figureNumber == 2
                    => new Point(number: 8, character: 'g'),

                FigureType.Horse when directionType == DirectionType.Bottom && figureNumber == 1
                    => new Point(number: 1, character: 'b'),
                FigureType.Horse when directionType == DirectionType.Bottom && figureNumber == 2
                    => new Point(number: 1, character: 'g'),

                FigureType.Rook when directionType == DirectionType.Top && figureNumber == 1
                    => new Point(number: 8, character: 'a'),
                FigureType.Rook when directionType == DirectionType.Top && figureNumber == 2
                    => new Point(number: 8, character: 'h'),

                FigureType.Rook when directionType == DirectionType.Bottom && figureNumber == 1
                    => new Point(number: 1, character: 'a'),
                FigureType.Rook when directionType == DirectionType.Bottom && figureNumber == 2
                    => new Point(number: 1, character: 'h'),

                FigureType.Pawn when directionType == DirectionType.Top
                    => new Point(y: 1, x: figureNumber - 1),
                FigureType.Pawn when directionType == DirectionType.Bottom
                    => new Point(y: 6, x: figureNumber - 1),

                _ => throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null)
            };

        }
    }
}