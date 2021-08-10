namespace FFPF
{
    public struct Sector
    {
        /// <summary>
        /// 前16位 x索引 后16位 y索引
        /// </summary>
        public int id;
        /// <summary>
        /// 左下角坐标
        /// </summary>
        public int x;
        /// <summary>
        /// 左下角坐标
        /// </summary>
        public int y;
        public Grid[] grids;
        public PortalWindow[] protals;
    }
}