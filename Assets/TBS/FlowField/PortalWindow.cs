using System.Runtime.InteropServices;

namespace TBS.FlowField
{
    [StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
    public struct PortalWindow
    {
        /// <summary>
        /// 窗口是水平的还是垂直的
        /// </summary>
        public bool horizonOrVertical;
        /// <summary>
        /// 窗口起始位置
        /// </summary>
        public int min;
        /// <summary>
        /// 窗口结束位置
        /// </summary>
        public int max;
        /// <summary>
        /// 窗口所在sectorID
        /// </summary>
        public int sectorID;
    }
}