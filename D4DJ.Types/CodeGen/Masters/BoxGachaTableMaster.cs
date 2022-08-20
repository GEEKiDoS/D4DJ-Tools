using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class BoxGachaTableMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int TableId { get; set; }
		[Key(2)]
		public RewardCategory Category { get; set; }
		[Key(3)]
		public int RewardId { get; set; }
		[Key(4)]
		public int Amount { get; set; }
		[Key(5)]
		public int MaxCount { get; set; }
		[Key(6)]
		public int AscendingSortId { get; set; }
	}
}

