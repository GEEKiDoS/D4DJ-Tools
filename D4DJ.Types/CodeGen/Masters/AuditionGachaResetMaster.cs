using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class AuditionGachaResetMaster
	{
		[Key(0)]
		public int __GachaDrawPrimaryKey__ { get; set; }
		[Key(1)]
		public int __StockPrimaryKey__ { get; set; }
		[Key(2)]
		public int StockAmount { get; set; }
	}
}

