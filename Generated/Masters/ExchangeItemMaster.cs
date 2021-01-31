using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ExchangeItemMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __ExchangePrimaryKey__ { get; set; }
		[Key(2)]
		public int _unused { get; set; }
		[Key(3)]
		public RewardCategory RewardCategory { get; set; }
		[Key(4)]
		public int RewardId { get; set; }
		[Key(5)]
		public int RewardAmount { get; set; }
		[Key(6)]
		public int ExchangeCount { get; set; }
		[Key(7)]
		public DateSelectCategory ResetType { get; set; }
		[Key(8)]
		public int ResetValue { get; set; }
		[Key(9)]
		public bool Recommend { get; set; }
		[Key(10)]
		public DateTime StartDate { get; set; }
		[Key(11)]
		public DateTime EndDate { get; set; }
		[Key(12)]
		public int RequiredStockId1 { get; set; }
		[Key(13)]
		public int RequiredAmount1 { get; set; }
		[Key(14)]
		public int RequiredStockId2 { get; set; }
		[Key(15)]
		public int RequiredAmount2 { get; set; }
		[Key(16)]
		public int RequiredStockId3 { get; set; }
		[Key(17)]
		public int RequiredAmount3 { get; set; }
		[Key(18)]
		public int RequiredStockId4 { get; set; }
		[Key(19)]
		public int RequiredAmount4 { get; set; }
	}
}

