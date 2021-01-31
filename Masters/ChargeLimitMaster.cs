using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
    public class ChargeLimitMaster
	{
		[Key(0)]
		public int Age { get; set; }
		[Key(1)]
		public int ChageLimitYen { get; set; }
	}
}
