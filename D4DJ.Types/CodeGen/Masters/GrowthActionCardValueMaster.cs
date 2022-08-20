using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthActionCardValueMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Value { get; set; }
	}
}

