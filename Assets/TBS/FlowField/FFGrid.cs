using System.Runtime.InteropServices;

namespace TBS.FlowField
{
    [StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
    public struct Grid
    {
        /// <summary>
        /// x坐标
        /// </summary>
        public int x;
        /// <summary>
        /// y坐标
        /// </summary>
        public int y;
        /// <summary>
        /// 所在sectorID
        /// </summary>
        public int sectorId;

        public byte cost;
        public byte flags;
        public ushort integration;
    }
}