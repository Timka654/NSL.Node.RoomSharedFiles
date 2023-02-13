
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSL.SocketCore.Utils.Buffer;

namespace NSL.Node.RoomServer.Shared
{
    public partial class GameInfo
    {
        public IRoomInfo RoomInfo { get; }

        public GameInfo(IRoomInfo roomInfo)
        {
            RoomInfo = roomInfo;

            roomInfo.RegisterHandle(11, testCommand_handle);
        }
    }
}
