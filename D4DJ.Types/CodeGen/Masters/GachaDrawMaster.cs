using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GachaDrawMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __GachaPrimaryKey__ { get; set; }
		[Key(2)]
		public int[] DrawAmounts { get; set; }
		[Key(3)]
		public int __StockPrimaryKey__ { get; set; }
		[Key(4)]
		public int StockAmount { get; set; }
		[Key(5)]
		public int DrawLimit { get; set; }
		[Key(6)]
		public bool IsResetLimitEveryday { get; set; }
		[Key(7)]
		public int[] __RouletteTargetsPrimaryKey__ { get; set; }
		[Key(8)]
		public int[] RouletteRates { get; set; }
	}
}

