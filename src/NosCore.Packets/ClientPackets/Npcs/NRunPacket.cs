﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Npcs
{
    [PacketHeader("n_run")]
    public class NrunPacket : PacketBase
    {
        [PacketIndex(0)] public NrunRunnerType Runner { get; set; }

        [PacketIndex(1, IsOptional = true)] public short? Type { get; set; }

        [PacketIndex(2, IsOptional = true)] public VisualType? VisualType { get; set; }

        [PacketIndex(3, IsOptional = true)] public long? VisualId { get; set; }
    }
}