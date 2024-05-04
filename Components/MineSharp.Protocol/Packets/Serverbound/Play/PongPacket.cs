﻿using MineSharp.Core.Common;
using MineSharp.Data;
using MineSharp.Data.Protocol;

namespace MineSharp.Protocol.Packets.Serverbound.Play;

/// <summary>
/// Pong Packet https://wiki.vg/Protocol#Ping_Response_.28play.29
/// </summary>
/// <param name="id"></param>
public class PongPacket(long id) : IPacket
{
    /// <inheritdoc />
    public PacketType Type => PacketType.SB_Play_Pong;

    /// <summary>
    /// Pong id
    /// </summary>
    public long Id { get; set; } = id;
    
    /// <inheritdoc />
    public void Write(PacketBuffer buffer, MinecraftData version)
    {
        buffer.WriteLong(this.Id);
    }

    /// <inheritdoc />
    public static IPacket Read(PacketBuffer buffer, MinecraftData version)
    {
        return new PongPacket(
            buffer.ReadLong());
    }
}
