﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSL.Node.RoomServer.Shared.Enums
{
    public enum RoomPacketEnum
    {
        SignSession = 1,
        SignSessionResult = SignSession,
        ChangeNodeList,
        Transport,
        Broadcast,
        ReadyNode,
        ReadyNodeResult = ReadyNode,
        ReadyRoom,
        Execute
    }
}
