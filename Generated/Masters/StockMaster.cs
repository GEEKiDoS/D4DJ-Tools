using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class StockMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public StockCategory Category { get; set; }
		[Key(3)]
		public int __ViewCategoryPrimaryKey__ { get; set; }
		[Key(4)]
		public string Summary { get; set; }
		[Key(5)]
		public int AttributeId { get; set; }
		[Key(6)]
		public int Rarity { get; set; }
		[Key(7)]
		public int Exp { get; set; }
		[Key(8)]
		public int BuffCharacterId { get; set; }
		[Key(9)]
		public int RecoveryAmount { get; set; }
		[Key(10)]
		public int ConsumeAmount { get; set; }
		[Key(11)]
		public int MaxAmount { get; set; }
		[Key(12)]
		public DateTime StartDate { get; set; }
		[Key(13)]
		public DateTime EndDate { get; set; }
		[Key(14)]
		public bool IsAppropriateSales { get; set; }
	}
}

