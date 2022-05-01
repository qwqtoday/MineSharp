﻿using MineSharp.Core.Logging;
using MineSharp.Core.Types;
using MineSharp.Data.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSharp.Data.Entities {
    public class Entity {

        Logger Logger = Logger.GetLogger();

        public int Id { get; set; }
        public Vector3 Position { get; set; }
        public float Pitch { get;  set; }
        public float Yaw { get; set; }
        public EntityInfo EntityInfo { get; set; }
        public Vector3 Velocity { get; set; }
        public bool IsOnGround { get; set; }
        public Dictionary<EffectType, Effect> Effects { get; set; }
        public Entity(EntityInfo info, int id, Vector3 position, float pitch, float yaw, Vector3 velocity, bool isOnGround) {
            this.Id = id;
            this.EntityInfo = info;
            this.Position = position;
            this.Pitch = pitch;
            this.Yaw = yaw;
            this.Velocity = velocity;
            this.IsOnGround = isOnGround;
            this.Effects = new Dictionary<EffectType, Effect>();
        }


        public int? GetEffectLevel(EffectType type) {

            if (!Effects.TryGetValue(type, out var effect)) {
                return null;
            }
            
            return effect?.Amplifier + 1;
        }
    }
}
