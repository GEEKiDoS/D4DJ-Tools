using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MusicMixMaster
	{
		[Key(0)]
		public int __MusicPrimaryKey__ { get; set; }
		[Key(1)]
		public ChartSectionType Section { get; set; }
		[Key(2)]
		public float StartTime { get; set; }
		[Key(3)]
		public float StartTimeBpm { get; set; }
		[Key(4)]
		public float EndTime { get; set; }
		[Key(5)]
		public float EndTimeBpm { get; set; }
	}
}

