using NSL.SocketCore.Utils.Buffer;
using System;
using System.Collections.Generic;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public interface IRoomInfo
    {
        void Broadcast(OutputPacketBuffer packet);

        PlayerInfo GetPlayer(Guid id);

        void SendTo(Guid nodeId, OutputPacketBuffer packet);

        void SendTo(PlayerInfo player, OutputPacketBuffer packet, bool disposeOnSend = true);

        void RegisterHandle(ushort command, ReciveHandleDelegate action);

        void Execute(ushort command, Action<OutputPacketBuffer> build);

        void SendToRoomServer(OutputPacketBuffer packet);

        bool Broadcast(Action<OutputPacketBuffer> builder, ushort code);

        bool Broadcast(Action<OutputPacketBuffer> builder);
        IEnumerable<IPlayerNetwork> GetNodes();
    }
}
