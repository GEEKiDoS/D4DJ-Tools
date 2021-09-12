using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GachaBonusMaster
	{
		[Key(0)]
		public int GachaId { get; set; }
		[Key(1)]
		public bool IsMain { get; set; }
		[Key(2)]
		public int MaxValue { get; set; }
		[Key(3)]
		public int __TableRatePrimaryKey__ { get; set; }
		[Key(4)]
		public int[] TableIds { get; set; }
		[Key(5)]
		public string Text { get; set; }
	}
}

