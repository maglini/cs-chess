using System;
using System.Collections.Generic;

namespace Logic.Utils;

public class Point
{
    public int X { get; protected set; }
    public int Y { get; protected set; }

    public int Number { get; protected set; }
    public char Character { get; protected set; }

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