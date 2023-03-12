using NSL.SocketCore.Utils;
using NSL.SocketCore.Utils.Buffer;
using NSL.UDP;
using NSL.UDP.Enums;
using System;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public interface IPlayerNetwork : IDisposable
    {
        void Transport(Action<OutputPacketBuffer> build, ushort code);

        void Transport(Action<OutputPacketBuffer> build);

        void Send(OutputPacketBuffer packet, bool disposeOnSend = true);


        void Transport(Action<DgramPacket> build, ushort code, UDPChannelEnum channel = UDPChannelEnum.ReliableOrdered);

        void Transport(Action<DgramPacket> build, UDPChannelEnum channel = UDPChannelEnum.ReliableOrdered);

        void Send(DgramPacket packet, UDPChannelEnum channel = UDPChannelEnum.ReliableOrdered, bool disposeOnSend = true);

        ClientObjectBag ObjectBag { get; }

        void InitializeObjectBag();

    }
}
