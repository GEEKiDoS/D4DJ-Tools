using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class LimitBreakItemMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __RarityPrimaryKey__ { get; set; }
		[Key(2)]
		public int __AttributePrimaryKey__ { get; set; }
		[Key(3)]
		public int LimitBreakCount { get; set; }
		[Key(4)]
		public int __StockPrimaryKey__ { get; set; }
		[Key(5)]
		public int Amount { get; set; }
	}
}

