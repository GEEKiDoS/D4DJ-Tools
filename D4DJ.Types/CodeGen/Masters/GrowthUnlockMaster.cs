using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthUnlockMaster
	{
		[Key(0)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(1)]
		public int __LockMemberPrimaryKey__ { get; set; }
		[Key(2)]
		public int StockId { get; set; }
		[Key(3)]
		public int Amount { get; set; }
	}
}

