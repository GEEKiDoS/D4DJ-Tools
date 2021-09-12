using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class SlotRewardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __StockPrimaryKey__ { get; set; }
		[Key(2)]
		public int Amount { get; set; }
		[Key(3)]
		public int NormalRate { get; set; }
		[Key(4)]
		public int ChanceTimeRate { get; set; }
		[Key(5)]
		public int EffectId { get; set; }
		[Key(6)]
		public int CardId { get; set; }
		[Key(7)]
		public int StampId { get; set; }
	}
}

