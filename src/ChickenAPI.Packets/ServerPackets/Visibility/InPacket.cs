﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Visibility
{
    [PacketHeader("in")]
    public class InPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public string Name { get; set; }

        [PacketIndex(2)]
        public string VNum { get; set; }

        [PacketIndex(3)]
        public long VisualId { get; set; }

        [PacketIndex(4)]
        public short PositionX { get; set; }

        [PacketIndex(5)]
        public short PositionY { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public byte? Direction { get; set; }

        [PacketIndex(7, IsOptional = true)]
        public InCharacterSubPacket InCharacterSubPacket { get; set; }

        [PacketIndex(8, IsOptional = true)]
        public InItemSubPacket InItemSubPacket { get; set; }

        [PacketIndex(9, IsOptional = true)]
        public InNonPlayerSubPacket InNonPlayerSubPacket { get; set; }
    }
}