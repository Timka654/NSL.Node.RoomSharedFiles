using NSL.SocketCore.Utils.Buffer;
using System;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public interface IPlayerNetwork
    {
        void Transport(Action<OutputPacketBuffer> build, ushort code);

        void Transport(Action<OutputPacketBuffer> build);

        void Send(OutputPacketBuffer packet, bool disposeOnSend = true);
    }
}
