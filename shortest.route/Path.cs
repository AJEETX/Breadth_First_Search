using System;
using System.Collections.Generic;
namespace shortest.route
{
    internal class ChessKnight
    {
        //static int[,] movement = new int[,] {{2,-1},{ 2,1},{ -2,1},{ -2,-1},{ 1,2},{1,-2},{ -1,2},{ -1,-2}};
        static int[] row = new int[] {2, 2, -2, -2, 1, 1, -1, -1};
        static int[] col = new int[] {-1, 1, 1, -1, 2, -2, 2, -2};
        static bool valid(int x, int y, int N)
        {
            if (x < 0 || y < 0 || x >= N || y >= N) return false;
            return true;
        }
        public static int ShortestPath(Node src, Node dest, int N)
        {
            var visited = new Dictionary<Node, bool>();
            var q = new Queue<Node>();
            q.Enqueue(src);
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                int x = node.x;
                int y = node.y;
                int dist = node.dist;
                if (x == dest.x && y == dest.y) return dist;
                if (!visited.ContainsKey(node))
                {
                    visited[node] = true;
                    for (int i = 0; i < 8; ++i)
                    {
                        int x1 = x + row[i];
                        int y1 = y + col[i];
                        if (valid(x1, y1, N)) 
                            q.Enqueue(new Node(x1, y1, dist + 1));
                    }
                }
            } return int.MaxValue;
        }
    }
}