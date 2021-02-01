using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RaidBossMaster
	{
		[Key(0)]
		public int __AggregationPrimaryKey__ { get; set; }
		[Key(1)]
		public int RoomId { get; set; }
		[Key(2)]
		public int EventId { get; set; }
		[Key(3)]
		public string Name { get; set; }
		[Key(4)]
		public long Hp { get; set; }
	}
}

