﻿using MineSharp.Bot.Enums;
using MineSharp.Core.Types;
using MineSharp.Core.Types.Enums;
using MineSharp.Data.Blocks;
using MineSharp.Protocol.Packets;
using MineSharp.World;
using MineSharp.World.Chunks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSharp.Bot {
    public partial class Bot {

        public World.World World { get; private set; }

        private partial void LoadWorld() {
            this.World = new World.World();
        }

        private void handleChunkDataAndLightUpdate(MineSharp.Protocol.Packets.Clientbound.Play.ChunkDataAndLightUpdatePacket packet) {
            World.LoadChunkPacket(packet);
        }

        private void handleUnloadChunk(MineSharp.Protocol.Packets.Clientbound.Play.UnloadChunkPacket packet) {
            World.UnloadChunk(new ChunkCoordinates(packet.ChunkX, packet.ChunkZ));
        }

        private void handleBlockUpdate(MineSharp.Protocol.Packets.Clientbound.Play.BlockChangePacket packet) {
            Block newBlock = new Block(BlockData.StateToBlockMap[packet.BlockID], packet.Location, packet.BlockID);
            World.SetBlock(newBlock);
        }

        private void handleMultiBlockChange(MineSharp.Protocol.Packets.Clientbound.Play.MultiBlockChangePacket packet) {
            int sectionX = (int)(packet.Chunksectionposition >> 42);
            int sectionY = (int)(packet.Chunksectionposition & 0xFFFFF);
            int sectionZ = (int)((packet.Chunksectionposition >> 20) & 0x3FFFFF);

            if (sectionX > Math.Pow(2, 21)) sectionX -= (int)Math.Pow(2, 22);
            if (sectionY > Math.Pow(2, 19)) sectionY -= (int)Math.Pow(2, 20);
            if (sectionZ > Math.Pow(2, 21)) sectionZ -= (int)Math.Pow(2, 22);

            sectionY += Math.Abs(MineSharp.World.World.MinY / MineSharp.World.Chunks.Chunk.ChunkSectionLength);

            var chunk = World.GetChunkAt(new ChunkCoordinates(sectionX, sectionZ));
            if (chunk == null) return;
            chunk.ChunkSections[sectionY].Update(packet.Blocks); //TODO: World Block update event
        }

        /// <summary>
        /// Returns a Task that finishes once the Chunks in a square with length <paramref name="length"/> have been loaded
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public async Task WaitForChunksToLoad(int length = 5) {

            await WaitForBot();

            var playerChunk = World.GetChunkCoordinates((int)BotEntity.Position.X, (int)BotEntity.Position.Z);
            for (int x = playerChunk.X - length; x < playerChunk.X + length; x++) {
                for (int z = playerChunk.Z - length; z < playerChunk.Z + length; z++) {
                    while (World.GetChunkAt(new ChunkCoordinates(x, z)) == null) await Task.Delay(10);
                }
            }
        }

        public Block GetBlockAt(Position pos) => World.GetBlockAt(pos);
        public Task<Block[]?> FindBlocksAsync(BlockType type, int count = -1, CancellationToken? cancellation = null) => World.FindBlocksAsync(type, count, cancellation);
        public Task<Block?> FindBlockAsync(BlockType type, CancellationToken? cancellation = null) => World.FindBlockAsync(type, cancellation);
    }
}
