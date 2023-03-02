using NSL.SocketCore.Utils;
using System;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public class PlayerInfo
    {
        public IPlayerNetwork Network { get; }

        public Guid Id { get; }

        ClientObjectBag ObjectBag => Network.ObjectBag;

        public void InitializeObjectBag()
            => Network.InitializeObjectBag();

        public PlayerInfo(IPlayerNetwork network, Guid id)
        {
            Network = network;
            Id = id;
        }
    }
}
