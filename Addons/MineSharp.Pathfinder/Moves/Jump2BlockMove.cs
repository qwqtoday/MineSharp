using MineSharp.Bot;
using MineSharp.Bot.Enums;
using MineSharp.Core.Logging;
using MineSharp.Core.Types;
using MineSharp.Data.Blocks;

namespace MineSharp.Pathfinding.Moves
{
    public class Jump2BlockMove : Move
    {
        private static readonly Logger Logger = Logger.GetLogger();
        public override float MoveCost => 100;
        public override Vector3 MoveVector { get; }

        public Jump2BlockMove(Movements movements, Vector3 direction) : base(movements)
        {
            this.MoveVector = direction * 3;
        }
        
        public override bool IsMovePossible(Vector3 startPosition, World.World world)
        {
            var target = startPosition.Plus(this.MoveVector);

            if (!this.HasBlockSpaceForStanding(target, world))
            {
                return false;
            }

            for (int i = 1; i <= 2; i++)
            {
                var blockToSkipPos = startPosition.Plus((this.MoveVector / 3) * i);
                
                var blockToSkip = world.GetBlockAt(blockToSkipPos);
                if (blockToSkip.GetBoundingBoxes().Length > 0)
                {
                    return false;
                }

                var blockToSkipAbove = world.GetBlockAt(blockToSkipPos.Plus(Vector3.Up));
                if (blockToSkipAbove.GetBoundingBoxes().Length > 0)
                {
                    return false;
                }

                var blockToSkipAbove2 = world.GetBlockAt(blockToSkipPos.Plus(Vector3.Up * 2));
                if (blockToSkipAbove2.GetBoundingBoxes().Length > 0)
                {
                    return false;
                }
            }
            
            return true;
        }

        protected override void OnTick(MinecraftBot bot, Vector3 target)
        {
            var diff = bot.BotEntity!.Position.Minus(target);
            var length = diff.Length();
            Logger.Debug($"Pos: {bot.BotEntity!.Position}, Len: {length}");
                
            var yaw = Math.Atan2(diff.X, -diff.Z) * (180 / Math.PI);
                
            bot.ForceSetRotation((float)yaw, 0);

            if (length is > 2d and < 2.4d)
            {
                Logger.Debug("Jump");
                bot.PlayerControls.Jump();
            }
            
            bot.PlayerControls.Walk(WalkDirection.Forward);

            if (length <= THRESHOLD)
            {
                this.TSC.SetResult();
                return;
            }
        }
    }
}