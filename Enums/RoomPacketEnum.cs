namespace NSL.Node.RoomServer.Shared.Client.Core.Enums
{
    public enum RoomPacketEnum
    {
        Response = 1,
        SignSession,
        SignSessionResult = SignSession,
        ChangeNodeList,
        Transport,
        Broadcast,
        ReadyNodeRequest,
        ReadyRoom,
        Execute,
        StartupInfoMessage,
    }
}
