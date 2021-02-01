using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventMedleySetlistMaster
	{
		[Key(0)]
		public int __AggregationPrimaryKey__ { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int[] MusicIds { get; set; }
		[Key(3)]
		public int RequiredPoint { get; set; }
	}
}

