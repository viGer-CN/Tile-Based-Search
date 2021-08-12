namespace TBS.JPSP
{
    public struct Sector
    {
        //x|y
        public int id;
        //sectorSize为单位的坐标 原点是地图origin
        public short x;
        public short y;
        public Grid[] grids;//12x12 size乘以sizeof(Grid)需要能整除64
    }
}