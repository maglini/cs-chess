using System.Windows;
using Logic.Implementation;
using Logic.Infrastructure.Basis;

namespace App;

/// <summary>
/// Interaction logic for GameWindow.xaml
/// </summary>
public partial class GameWindow : Window
{
    public GameWindow()
    {
        Board board = new Board(new GameOptions());
        //this.f.Children.Add(new Grid()
        //{
        //    Name = "Board", Background = new SolidColorBrush(ColorType.FromRgb(21,0,0)), Width = 500, Height = 500,
        //});
        InitializeComponent();
    }
}

