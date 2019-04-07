﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Login
{
    [PacketHeader("EntryPoint", 3, AnonymousAccess = true)]
    public class EntryPointPacket : IPacket
    {
        [PacketIndex(0)]
        public string Title { get; set; }

        [PacketIndex(1)]
        public string Packet1Id { get; set; }

        [PacketIndex(2)]
        public string Name { get; set; }

        [PacketIndex(3)]
        public string Packet2Id { get; set; }

        [PacketIndex(4)]
        public string Password { get; set; }
    }
}