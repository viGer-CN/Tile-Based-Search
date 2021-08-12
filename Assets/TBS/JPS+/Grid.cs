using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TBS.JPSP
{
    public struct Grid
    {
        //grid size单位坐标 原点map origin
        public short x;
        public short y;
        public int sectorId;
        public char cost;
        //四个有效位 表示四个方向的primary jump point
        public byte primaryJump;
        
        //四个方向的straight jump point
        public short straightJump0;
        public short straightJump1;
        public short straightJump2;
        public short straightJump3;
        
        //四个方向的diagonal jump point
        public short diagonalJump0;
        public short diagonalJump1;
        public short diagonalJump2;
        public short diagonalJump3;
    }
}

