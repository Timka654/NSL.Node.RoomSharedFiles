using System;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public class PlayerInfo
    {
        public IPlayerNetwork Network { get; set; }

        public Guid Id { get; set; }
    }
}
