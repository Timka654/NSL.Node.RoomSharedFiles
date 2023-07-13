using NSL.Extensions.Session;
using NSL.Generators.BinaryTypeIOGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSL.Node.Core.Models.Response
{
    [BinaryIOType, BinaryIOMethodsFor]
    public partial class RoomNodeSignInResponseModel
    {
        public bool Success { get; set; }

        public Guid? NodeId { get; set; }

        public Dictionary<string, string> Options { get; set; }

        public NSLSessionInfo SessionInfo { get; set; }
    }
}
