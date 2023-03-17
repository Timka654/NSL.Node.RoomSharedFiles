namespace NSL.Node.RoomServer.Shared.Client.Core.Enums
{
    public enum RoomPacketEnum
    {
        SignSession = 1,
        SignSessionResult = SignSession,
        ChangeNodeList,
        Transport,
        Broadcast,
        ReadyNodeRequest,
        ReadyRoom,
        Execute,
        StartupInfoMessage,
        Response
    }
}
