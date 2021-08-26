using System;
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
        //表示该节点是否是前置节点沿StraightDirection过来后的一个拐点（路口点）
        public byte primaryJump;
        
        //四个方向的straight jump point
        //表示沿该StraightDirection前进这么多个tile，会到达一个该方向的primary jump point
        //负数表示到墙面距离
        public short straightJump0;
        public short straightJump1;
        public short straightJump2;
        public short straightJump3;
        
        //四个方向的diagonal jump point
        //表示沿着DiagonalDirection前进这么多个tile，会到达一个分量方向上的straight jump point
        //或primary jump point
        //负数表示到墙面距离
        public short diagonalJump0;
        public short diagonalJump1;
        public short diagonalJump2;
        public short diagonalJump3;

        public bool GetPrimaryJump(StraightDirection dir)
        {
            return (primaryJump & (1 << (int) dir)) > 0;
        }

        public void SetPrimaryJump(StraightDirection dir, bool value)
        {
            int mask = 1 << (int)dir;
            if (value)
            {
                primaryJump |= (byte)mask;
            }
            else
            {
                primaryJump &= (byte)~mask;
            }
        }

        public short GetStraightJump(StraightDirection dir)
        {
            switch (dir)
            {
                case StraightDirection.Up: return straightJump0;
                case StraightDirection.Down: return straightJump1;
                case StraightDirection.Left: return straightJump2;
                case StraightDirection.Right: return straightJump3;
                default:
                    throw new NotSupportedException(dir.ToString());
            }
        }

        public void SetStraightJump(StraightDirection dir, short value)
        {
            switch (dir)
            {
                case StraightDirection.Up: straightJump0 = value; break;
                case StraightDirection.Down: straightJump1 = value; break;
                case StraightDirection.Left: straightJump2 = value; break;
                case StraightDirection.Right: straightJump3 = value; break;
                default:
                    throw new NotSupportedException(dir.ToString());
            }
        }
        
        public short GetDiagonalJump(DiagonalDirection dir)
        {
            switch (dir)
            {
                case DiagonalDirection.UpLeft: return diagonalJump0;
                case DiagonalDirection.UpRight: return diagonalJump1;
                case DiagonalDirection.DownLeft: return diagonalJump2;
                case DiagonalDirection.DownRight: return diagonalJump3;
                default:
                    throw new NotSupportedException(dir.ToString());
            }
        }

        public void SetDiagonalJump(DiagonalDirection dir, short value)
        {
            switch (dir)
            {
                case DiagonalDirection.UpLeft: diagonalJump0 = value; break;
                case DiagonalDirection.UpRight: diagonalJump1 = value; break;
                case DiagonalDirection.DownLeft: diagonalJump2 = value; break;
                case DiagonalDirection.DownRight: diagonalJump3 = value; break;
                default:
                    throw new NotSupportedException(dir.ToString());
            }
        }
    }
}

