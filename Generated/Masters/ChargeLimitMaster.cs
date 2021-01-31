using MessagePack;
using System;

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

