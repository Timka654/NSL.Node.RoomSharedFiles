using NSL.Generators.BinaryTypeIOGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSL.Node.Core.Models.Requests
{
    [BinaryIOType, BinaryIOMethodsFor]
    public partial class RoomNodeReadyRequestModel
    {
        public int ConnectedNodesCount { get; set; }

        public List<string> ConnectedNodes { get; set; }
    }
}
