using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RaidSpecialBossMaster
	{
		[Key(0)]
		public int GroupId { get; set; }
		[Key(1)]
		public int[] BossIds { get; set; }
		[Key(2)]
		public int EventId { get; set; }
		[Key(3)]
		public BossLoopType BossLoopType { get; set; }
	}
}

