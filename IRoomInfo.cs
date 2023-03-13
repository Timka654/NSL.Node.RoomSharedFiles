using NSL.SocketCore.Utils.Buffer;
using NSL.UDP;
using System;
using System.Collections.Generic;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public interface IRoomInfo
    {
        void RegisterHandle(ushort command, ReciveHandleDelegate action);


        void Broadcast(DgramOutputPacketBuffer packet, bool disposeOnSend = true); // +

        bool Broadcast(ushort code, Action<DgramOutputPacketBuffer> builder);

        bool Broadcast(Action<DgramOutputPacketBuffer> builder);


        bool SendTo(Guid nodeId, DgramOutputPacketBuffer packet, bool disposeOnSend = true); // +

        bool SendTo(NodeInfo node, DgramOutputPacketBuffer packet, bool disposeOnSend = true);

        bool SendTo(Guid nodeId, ushort command, Action<DgramOutputPacketBuffer> build);

        bool SendTo(NodeInfo node, ushort command, Action<DgramOutputPacketBuffer> build);


        void SendToServer(OutputPacketBuffer packet, bool disposeOnSend = true);

        void SendToServer(ushort command, Action<OutputPacketBuffer> build);


        IEnumerable<NodeInfo> GetNodes();

        NodeInfo GetNode(Guid id);

        event Action<NodeInfo> OnNodeConnect;

        event Action OnRoomReady;

        Guid LocalNodeId { get; }
    }
}
