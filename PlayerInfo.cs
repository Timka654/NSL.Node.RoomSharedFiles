using NSL.SocketCore.Utils.Buffer;
using System;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public delegate void ReciveHandleDelegate(PlayerInfo nodePlayer, InputPacketBuffer buffer);

    public class PlayerInfo
    {
        public IPlayerNetwork Network { get; set; }

        public Guid Id { get; set; }
    }
}
