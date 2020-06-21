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
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Commands
{
    [PacketHeader("%Familyleave")]
    [PacketHeaderAlias("%Congédefamill", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienaustritt", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Uscita", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Salida", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familyleave", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Покинуть", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%AileÇaðrýsý", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Opustit", Flag = nameof(RegionType.CS))]
    public class FamilyLeavePacket : PacketBase
    {
    }
}