﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("walk")]
    public class WalkPacket : IPacket
    {
        [PacketIndex(0)]
        public short XCoordinate { get; set; }

        [PacketIndex(1)]
        public short YCoordinate { get; set; }

        [PacketIndex(2)]
        public short Unknown { get; set; } //TODO to find

        [PacketIndex(3)]
        public short Speed { get; set; }
    }
}