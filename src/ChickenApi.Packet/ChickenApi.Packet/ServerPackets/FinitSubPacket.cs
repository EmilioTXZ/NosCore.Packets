﻿using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("finit_subpacket")]
    public class FinitSubPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public CharacterRelationType RelationType { get; set; }

        [PacketIndex(2)]
        public bool IsOnline { get; set; }

        [PacketIndex(3, SerializeToEnd = true)]
        public string CharacterName { get; set; }
    }
}