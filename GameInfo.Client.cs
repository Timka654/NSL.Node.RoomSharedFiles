#if !SERVER

using NSL.SocketCore.Utils.Buffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSL.Node.RoomServer.Shared
{
    public partial class GameInfo
    {
        //example for client handle
        // private void testCommand_handle(PlayerInfo player, InputPacketBuffer buffer)
        // {
        //     Debug.Log($"receive testCommand from {player?.Id.ToString() ?? "Server"}");
        // }
    }
}

#endif