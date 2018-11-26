using System;
using System.Collections.Generic;
namespace shortest.route
{
    internal class ChessKnight
    {
        static int[] row = new int[] {2, 2, -2, -2, 1, 1, -1, -1};
        static int[] col = new int[] {-1, 1, 1, -1, 2, -2, 2, -2};
        static bool valid(int x, int y, int N)
        {
            if (x < 0 || y < 0 || x >= N || y >= N) return false;
            return true;
        }
        public static int ShortestPath(Location src, Location dest, int N)
        {
            var visited = new Dictionary<Location, bool>();
            var q = new Queue<Location>();
            q.Enqueue(src);
            while (q.Count > 0)
            {
                var currentLocation = q.Dequeue();
                int x = currentLocation.x;
                int y = currentLocation.y;
                int dist = currentLocation.dist;
                if (x == dest.x && y == dest.y) return dist;
                if (!visited.ContainsKey(currentLocation))
                {
                    visited[currentLocation] = true;
                    for (int i = 0; i < 8; ++i)
                    {
                        int x1 = x + row[i];
                        int y1 = y + col[i];
                        if (valid(x1, y1, N)) 
                            q.Enqueue(new Location(x1, y1, dist + 1));
                    }
                }
            } return int.MaxValue;
        }
    }
}