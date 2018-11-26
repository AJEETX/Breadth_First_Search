using System;

namespace shortest.route
{
    class Program
    {
        static void Main(string[] args) {
            int N = 8;

            // source coordinates
            Node src = new Node(0, 0);

            // destination coordinates
            Node dest = new Node(7, 5);

            int steps=ChessKnight.ShortestPath(src, dest, N);
            Console.WriteLine("Minimum number of steps required is " + steps);
            Console.Read();
        }
    }
}