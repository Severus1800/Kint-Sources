﻿using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.Packets.ClientPackets
{
    [PacketHeader("Char_NEW_JOB", PassNonParseablePacket = true)]
    public class BrawlerCreatePacket : PacketDefinition
    {
        [PacketIndex(0)]
        public string Name { get; set; }

        [PacketIndex(1)]
        public byte Slot { get; set; }

        [PacketIndex(2)]
        public GenderType Gender { get; set; }

        [PacketIndex(3)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(4)]
        public HairColorType HairColor { get; set; }

        public override string ToString() => $"Create Character Name: {Name} Slot: {Slot}";
    }
}
