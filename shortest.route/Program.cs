using System;

namespace shortest.route
{
    class Program
    {
        static void Main(string[] args) {
            // chessboard size N xN
            int N = 8;

            // source coordinates
            Location src = new Location(0, 0);

            // destination coordinates
            Location dest = new Location(7, 5);

            int steps=ChessKnight.ShortestPath(src, dest, N);
            Console.WriteLine("Minimum number of steps required is " + steps);
            Console.Read();
        }
    }
}