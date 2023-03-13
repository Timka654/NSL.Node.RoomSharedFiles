using NSL.SocketCore.Utils;
using NSL.SocketCore.Utils.Buffer;
using NSL.UDP;
using NSL.UDP.Enums;
using System;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public interface INodeClientNetwork : IDisposable
    {
        void Send(Action<DgramOutputPacketBuffer> build, ushort code, UDPChannelEnum channel = UDPChannelEnum.ReliableOrdered);

        void Send(Action<DgramOutputPacketBuffer> build, UDPChannelEnum channel = UDPChannelEnum.ReliableOrdered);
        
        void Send(Action<DgramOutputPacketBuffer> build, ushort code);

        void Send(Action<DgramOutputPacketBuffer> build);

        void Send(DgramOutputPacketBuffer packet, UDPChannelEnum channel = UDPChannelEnum.ReliableOrdered, bool disposeOnSend = true);
        void Send(DgramOutputPacketBuffer packet, bool disposeOnSend = true);

        ClientObjectBag ObjectBag { get; }
        Guid NodeId { get; }
        bool IsLocalNode { get; }

        void InitializeObjectBag();

    }
}
