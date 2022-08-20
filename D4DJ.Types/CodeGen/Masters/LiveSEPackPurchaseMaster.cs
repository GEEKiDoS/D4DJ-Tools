using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class LiveSEPackPurchaseMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public DateTime StartDate { get; set; }
		[Key(2)]
		public DateTime EndDate { get; set; }
		[Key(3)]
		public int RequiredStockId { get; set; }
		[Key(4)]
		public int RequiredAmount { get; set; }
	}
}

