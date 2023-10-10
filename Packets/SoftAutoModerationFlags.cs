﻿using AssettoServer.Shared.Network.Packets;
using AssettoServer.Shared.Network.Packets.Outgoing;

namespace SoftAutoModerationPlugin.Packets;

public class SoftAutoModerationFlags : IOutgoingNetworkPacket
{
    public Flags Flags { get; set; }
    
    public void ToWriter(ref PacketWriter writer)
    {
        writer.Write((byte)ACServerProtocol.Extended);
        writer.Write((byte)CSPMessageTypeTcp.ClientMessage);
        writer.Write<byte>(255);
        writer.Write<ushort>(60000);
        writer.Write(0x79096D99);
        writer.Write(Flags);
    }
}

[Flags]
public enum Flags : byte
{
    NoLights = 1,
    NoParking = 2,
    WrongWay = 4
}
