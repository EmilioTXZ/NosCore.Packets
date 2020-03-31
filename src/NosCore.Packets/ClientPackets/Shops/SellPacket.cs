﻿using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("sell", BlockedByTrading = true)]
    public class SellPacket : PacketBase
    {
        [PacketIndex(2)]
        public short Data { get; set; }

        [PacketIndex(3)]
        [Range(0, byte.MaxValue)]
        public byte Slot { get; set; }

        [PacketIndex(4)]
        [Range(1, short.MaxValue)]
        public short Amount { get; set; }
    }
}