﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Specialists
{
    [PacketHeader("sd")]
    public class SdPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Cooldown { get; set; }
    }
}