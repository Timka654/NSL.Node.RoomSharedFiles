namespace NSL.Node.RoomServer.Shared.Client.Core
{
    public partial class GameInfo : IRoomSession
    {
#if SERVER
        public IServerRoomInfo RoomInfo { get; }

        public GameInfo(IServerRoomInfo roomInfo)
        {
            RoomInfo = roomInfo;

            // method must be implemented in client or server side, you can create one Initialize method for all sides
            Initialize();
        }

#else
        public IRoomInfo RoomInfo { get; }

        public GameInfo(IRoomInfo roomInfo)
        {
            RoomInfo = roomInfo;

            // method must be implemented in client or server side, you can create one Initialize method for all sides
            Initialize();
        }
#endif
    }
}
