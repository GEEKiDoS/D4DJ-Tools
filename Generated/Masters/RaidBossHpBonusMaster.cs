using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RaidBossHpBonusMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int AggregationId { get; set; }
		[Key(2)]
		public long Hp { get; set; }
		[Key(3)]
		public string Name { get; set; }
	}
}

