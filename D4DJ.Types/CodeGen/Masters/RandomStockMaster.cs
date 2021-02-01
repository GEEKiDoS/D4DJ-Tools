using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RandomStockMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int OriginalStockId { get; set; }
		[Key(2)]
		public int StockId { get; set; }
		[Key(3)]
		public int Amount { get; set; }
		[Key(4)]
		public int Rate { get; set; }
	}
}

