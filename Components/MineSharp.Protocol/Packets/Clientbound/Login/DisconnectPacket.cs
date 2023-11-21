using MineSharp.Core.Common;
using MineSharp.Data;
using MineSharp.Data.Protocol;

namespace MineSharp.Protocol.Packets.Clientbound.Login;

public class DisconnectPacket : IPacket
{
    public PacketType Type => PacketType.CB_Login_Disconnect;

    public Chat Reason { get; set; }

    public DisconnectPacket(Chat reason)
    {
        this.Reason = reason;
    }

    public void Write(PacketBuffer buffer, MinecraftData version)
    {
        buffer.WriteString(this.Reason.JSON);
    }

    public static IPacket Read(PacketBuffer buffer, MinecraftData version)
    {
        string reason = buffer.ReadString();
        return new DisconnectPacket(new Chat(reason));
    }
}
