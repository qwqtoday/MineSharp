﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSharp.World.Chunks {
    public struct ChunkCoordinates {

        public int X;
        public int Z;

        public ChunkCoordinates(int x, int z) {
            X = x;
            Z = z;
        }

        public override string ToString() {
            return $"({X} / {Z})";
        }

    }
}
