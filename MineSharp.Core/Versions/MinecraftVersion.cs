﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSharp.Core.Versions {
    public class MinecraftVersion {

        public int TickMs => 50;
        public double VelocityToBlock => 8000;

        public string Version { get; private set; } 
        public int ProtocolId { get; private set; }

        public MinecraftVersion(string version) {
            this.Version = version;
            this.ProtocolId = ProtocolVersion.GetVersionNumber(version);
        }

    }
}
