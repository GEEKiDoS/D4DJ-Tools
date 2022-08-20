using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class SlotBonusTimeMaster
	{
		[Key(0)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(1)]
		public int ExtendCount { get; set; }
		[Key(2)]
		public int PointRate { get; set; }
		[Key(3)]
		public int OwnedBonusCardPointRate { get; set; }
		[Key(4)]
		public int ExtraTrainingPointRate { get; set; }
		[Key(5)]
		public int ExtendTime { get; set; }
		[Key(6)]
		public int OwnedBonusCardExtendTime { get; set; }
		[Key(7)]
		public int ExtraTrainingExtendTime { get; set; }
		[Key(8)]
		public int __StockPrimaryKey__ { get; set; }
		[Key(9)]
		public int StockAmount { get; set; }
	}
}

