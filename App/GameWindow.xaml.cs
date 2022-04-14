using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Logic.Implementation;
using Logic.Infrastructure.Abstractions;
using Logic.Infrastructure.Basis;
using Logic.Infrastructure.EnumTypes;
using UI;
using UI.Common;

namespace App;

/// <summary>
/// Interaction logic for GameWindow.xaml
/// </summary>
public partial class GameWindow : Window
{
    protected Board Board { get; private set; }

    public GameWindow()
    {
        InitializeComponent();
        InitializeBoard();
    }

    protected void InitializeBoard()
    {
        this.Board = new Board(new GameOptions());

        List<Figure> figures = Board.Cells
            .Select(c => c.Figure)
            .Where(f => f != null)
            .ToList();

        IEnumerable<Grid> cellsGrids = BoardGrid.Children
            .Cast<Grid>()
            .ToList();

        foreach (Figure figure in figures)
        {
            Grid cellGrid = cellsGrids
                .First(c => Grid.GetRow(c) == figure.StartPosition.Y 
                         && Grid.GetColumn(c) == figure.StartPosition.X);
            
            cellGrid.Children.Add(new Label()
            {
                Content = FigureIcons.GetIcon(figure.FigureType),
                FontSize = figure.FigureType == FigureType.Pawn ? 25.0 : 38.0,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Foreground = figure.MyColorType == ColorType.White
                    ? Application.Current.Resources["WhiteFigureColor"] as SolidColorBrush
                    : Application.Current.Resources["BlackFigureColor"] as SolidColorBrush
            });
        }
    }
}

