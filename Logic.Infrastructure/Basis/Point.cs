using System;
using System.Collections.Generic;

namespace Logic.Infrastructure.Basis;

public struct Point
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public int Number { get; private set; }
    public char Character { get; private set; }

    private IList<char> _characters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
    private IList<int> _numbers = new List<int> { 8, 7, 6, 5, 4, 3, 2, 1 };

    public Point(int x, int y)
    {
        if (!(0 <= x && x <= 7))
            throw new ArgumentException($"X is not in range");

        if (!(0 <= y && y <= 7))
            throw new ArgumentException($"Y is not in range");

        X = x;
        Y = y;
        Character = _characters[x];
        Number = _numbers[y];
    }

    public Point(char character, int number)
    {
        Character = character;
        Number = number;

        X = _characters.IndexOf(character);
        Y = _numbers.IndexOf(number);
    }
}