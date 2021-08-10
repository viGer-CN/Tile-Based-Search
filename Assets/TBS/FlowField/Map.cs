using System.Collections.Generic;
using UnityEngine;

namespace TBS.FlowField
{
    public class Map
    {
        public Vector2 origin;
        public float gridSize;
        public Sector[] sectors;
        public Dictionary<int, int> sectorIdToIndex;
    }
}