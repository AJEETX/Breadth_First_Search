namespace shortest.route
{
    internal class Node
    {
        internal int x, y, dist;
        public Node(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Node(int x, int y, int dist)
        {
            this.x = x;
            this.y = y;
            this.dist = dist;
        }
    }
}