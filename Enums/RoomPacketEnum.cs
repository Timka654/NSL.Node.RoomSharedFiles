namespace NSL.Node.RoomServer.Shared.Client.Core.Enums
{
    public enum RoomPacketEnum
    {
        Response = 1,
        SignSessionRequest,
        TransportMessage,
        BroadcastMessage,
        ReadyNodeRequest,
        ReadyRoomMessage,
        ExecuteMessage,
        NodeConnectMessage,
        NodeConnectionLostMessage,
        NodeDisconnectMessage,
        NodeChangeEndPointMessage,
        DisconnectMessage,
        RoomDestroyMessage
    }
}
