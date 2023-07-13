using NSL.SocketCore.Utils;
using System;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public partial class NodeInfo
    {
        public INodeClientNetwork Network { get; private set; }

        public Guid Id { get; }

        public ClientObjectBag ObjectBag => Network.ObjectBag;

        public void InitializeObjectBag()
            => Network.InitializeObjectBag();

        public NodeInfo(INodeClientNetwork network, Guid id)
        {
            Network = network;
            Id = id;
        }

        public NodeInfo ChangeTo(INodeClientNetwork another)
        {
            Network = another;

            return this;
        }
    }
}
