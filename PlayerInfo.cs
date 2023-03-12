using NSL.SocketCore.Utils;
using System;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public partial class NodeInfo
    {
        public INodeNetwork Network { get; }

        public Guid Id { get; }

        ClientObjectBag ObjectBag => Network.ObjectBag;

        public void InitializeObjectBag()
            => Network.InitializeObjectBag();

        public NodeInfo(INodeNetwork network, Guid id)
        {
            Network = network;
            Id = id;
        }
    }
}
