﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Families
{
    [PacketHeader("glmk")]
    public class CreateFamilyPacket : PacketBase
    {
        [PacketIndex(0)]
        public string FamilyName { get; set; }
    }
}