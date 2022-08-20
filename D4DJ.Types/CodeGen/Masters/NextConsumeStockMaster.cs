using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class NextConsumeStockMaster
	{
		[Key(0)]
		public int __StockPrimaryKey__ { get; set; }
		[Key(1)]
		public int[] __NextStocksPrimaryKey__ { get; set; }
	}
}

