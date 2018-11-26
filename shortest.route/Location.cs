namespace shortest.route
{
    internal class Location
    {
        internal int x, y, dist;
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Location(int x, int y, int dist)
        {
            this.x = x;
            this.y = y;
            this.dist = dist;
        }
    }
}