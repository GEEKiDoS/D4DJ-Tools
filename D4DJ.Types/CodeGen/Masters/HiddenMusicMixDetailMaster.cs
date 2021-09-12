using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class HiddenMusicMixDetailMaster
	{
		[Key(0)]
		public int __MixPrimaryKey__ { get; set; }
		[Key(1)]
		public int Order { get; set; }
		[Key(2)]
		public float StartTime { get; set; }
		[Key(3)]
		public float StartTimeBpm { get; set; }
		[Key(4)]
		public float EndTime { get; set; }
		[Key(5)]
		public float EndTimeBpm { get; set; }
		[Key(6)]
		public bool EnableLongMixStart { get; set; }
		[Key(7)]
		public bool EnableLongMixEnd { get; set; }
	}
}

