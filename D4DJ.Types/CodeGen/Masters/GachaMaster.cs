using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GachaMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int[] __TableRatesPrimaryKey__ { get; set; }
		[Key(3)]
		public int[] TableIds { get; set; }
		[Key(4)]
		public int[] __PickUpCardsPrimaryKey__ { get; set; }
		[Key(5)]
		public string Summary { get; set; }
		[Key(6)]
		public bool HasSpecificBg { get; set; }
		[Key(7)]
		public DateTime StartDate { get; set; }
		[Key(8)]
		public DateTime EndDate { get; set; }
		[Key(9)]
		public string Note { get; set; }
		[Key(10)]
		public string Detail { get; set; }
		[Key(11)]
		public string[] Live2dBg { get; set; }
		[Key(12)]
		public int LoginTriggerMinutes { get; set; }
		[Key(13)]
		public bool ShowHomeAnimation { get; set; }
		[Key(14)]
		public bool HasPickUpDuplicateBonus { get; set; }
		[Key(15)]
		public int GachaCardAttribute { get; set; }
		[Key(16)]
		public int AscendingSortId { get; set; }
		[Key(17)]
		public GachaCategory Category { get; set; }
		[Key(18)]
		public int BonusStockId { get; set; }
		[Key(19)]
		public int SelectBonusMaxValue { get; set; }
		[Key(20)]
		public int[] __SelectBonusCardsPrimaryKey__ { get; set; }
		[Key(21)]
		public int[] __SelectBonusRewardsPrimaryKey__ { get; set; }
		[Key(22)]
		public int[] PickUpDuplicateBonusStockIds { get; set; }
		[Key(23)]
		public int[] PickUpDuplicateBonusStockAmounts { get; set; }
		[Key(24)]
		public GachaType Type { get; set; }
		[Key(25)]
		public int StepLoopCount { get; set; }
	}
}

