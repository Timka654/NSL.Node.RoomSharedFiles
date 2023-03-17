using NSL.SocketCore.Utils.Buffer;
using NSL.UDP;
using NSL.UDP.Enums;
using System;
using System.Collections.Generic;

namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public interface IRoomInfo
    {
        void RegisterHandle(ushort command, ReciveHandleDelegate action);


        void Broadcast(DgramOutputPacketBuffer packet, bool disposeOnSend = true); // +
        void Broadcast(DgramOutputPacketBuffer packet, UDPChannelEnum channel, bool disposeOnSend = true); // +

        bool Broadcast(ushort code, Action<DgramOutputPacketBuffer> builder);
        bool Broadcast(ushort code, UDPChannelEnum channel, Action<DgramOutputPacketBuffer> builder);

        bool Broadcast(Action<DgramOutputPacketBuffer> builder);
        bool Broadcast(UDPChannelEnum channel,Action<DgramOutputPacketBuffer> builder);


        bool SendTo(Guid nodeId, DgramOutputPacketBuffer packet, bool disposeOnSend = true); // +
        bool SendTo(Guid nodeId, UDPChannelEnum channel, DgramOutputPacketBuffer packet, bool disposeOnSend = true); // +

        bool SendTo(NodeInfo node, DgramOutputPacketBuffer packet, bool disposeOnSend = true);
        bool SendTo(NodeInfo node, UDPChannelEnum channel, DgramOutputPacketBuffer packet, bool disposeOnSend = true);

        bool SendTo(Guid nodeId, ushort command, Action<DgramOutputPacketBuffer> build);
        bool SendTo(Guid nodeId, ushort command, UDPChannelEnum channel, Action<DgramOutputPacketBuffer> build);

        bool SendTo(NodeInfo node, ushort command, Action<DgramOutputPacketBuffer> build);
        bool SendTo(NodeInfo node, ushort command, UDPChannelEnum channel, Action<DgramOutputPacketBuffer> build);


        void SendToServer(OutputPacketBuffer packet, bool disposeOnSend = true);
        void SendToServer(ushort command, Action<OutputPacketBuffer> build);


        IEnumerable<NodeInfo> GetNodes();

        NodeInfo GetNode(Guid id);

        event Action<NodeInfo> OnNodeConnect;

        event Action OnRoomReady;

        Guid LocalNodeId { get; }
    }
}
