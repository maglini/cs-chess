using System;
using Logic.Infrastructure.EnumTypes;

namespace UI.Common;

public static class FigureIcons
{
    private static string King = "♚";
    private static string Queen = "♛";
    private static string Elephant = "♝";
    private static string Horse = "♞";
    private static string Rook = "♜";
    private static string Pawn = "♟";

    public static string GetIcon(FigureType figureType)
    {
        return figureType switch
        {
            FigureType.King => King,
            FigureType.Queen => Queen,
            FigureType.Elephant => Elephant,
            FigureType.Horse => Horse,
            FigureType.Rook => Rook,
            FigureType.Pawn => Pawn,
            _ => throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null)
        };
    }
}