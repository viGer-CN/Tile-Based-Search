using System;
using UnityEngine;
using Grid = TBS.FlowField.Grid;

namespace Test
{
    public class Test : MonoBehaviour
    {
        private unsafe void Start()
        {
            //Debug.Log(Hash(10000,10000));
            //Debug.Log(Hash(9999,10000));
            //Debug.Log(Hash(5547,3453));
            //Debug.Log(Hash(3453,5547));
            var size = sizeof(TBS.JPSP.Grid);
            Debug.Log($"{size}, {size * 12 * 12 /64f}");
        }

        int Hash(int x, int y)
        {
            int hash = (x << 16) | y;
            return hash;
        }
    }
}