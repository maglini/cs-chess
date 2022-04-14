using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Infrastructure.Basis;

namespace Logic.Implementation.Extensions
{
    public static class PointExtensions
    {
        public static bool Exists(this IEnumerable<Point> points, Point point)
            => points.Any(p => point.Y == p.Y && point.X == p.X);

        public static bool Exists(this IEnumerable<Point> points, int y, int x)
            => points.Any(p => y == p.Y && x == p.X);
    }
}
