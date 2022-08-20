using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CardStackItemMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int StackCount { get; set; }
		[Key(2)]
		public int AttributeId { get; set; }
		[Key(3)]
		public int CharacterId { get; set; }
		[Key(4)]
		public int RarityId { get; set; }
		[Key(5)]
		public int __StockPrimaryKey__ { get; set; }
		[Key(6)]
		public int Amount { get; set; }
	}
}

