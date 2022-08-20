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
		public string GachaTypeName { get; set; }
		[Key(6)]
		public int __SummaryPrimaryKey__ { get; set; }
		[Key(7)]
		public bool HasSpecificBg { get; set; }
		[Key(8)]
		public DateTime StartDate { get; set; }
		[Key(9)]
		public DateTime EndDate { get; set; }
		[Key(10)]
		public int __DetailPrimaryKey__ { get; set; }
		[Key(11)]
		public int __NotePrimaryKey__ { get; set; }
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
		public int SelectBonusMaxValue { get; set; }
		[Key(19)]
		public int[] __SelectBonusCardsPrimaryKey__ { get; set; }
		[Key(20)]
		public int[] __SelectBonusRewardsPrimaryKey__ { get; set; }
		[Key(21)]
		public int[] PickUpDuplicateBonusStockIds { get; set; }
		[Key(22)]
		public int[] PickUpDuplicateBonusStockAmounts { get; set; }
		[Key(23)]
		public GachaType Type { get; set; }
		[Key(24)]
		public int StepLoopCount { get; set; }
		[Key(25)]
		public int[] __HomeAnimationCardsPrimaryKey__ { get; set; }
		[Key(26)]
		public DateTime OtherCardDate { get; set; }
		[Key(27)]
		public bool PickUpLevelMax { get; set; }
		[Key(28)]
		public int ShareCashBackRate { get; set; }
		[Key(29)]
		public int RandomBonusMaxValue { get; set; }
		[Key(30)]
		public int RandomBonusStockId { get; set; }
	}
}

