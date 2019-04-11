﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("blins")]
    public class BlInsPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}