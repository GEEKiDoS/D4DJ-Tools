using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RaidBossMaster
	{
		[Key(0)]
		public int __AggregationPrimaryKey__ { get; set; }
		[Key(1)]
		public int RoomId { get; set; }
		[Key(2)]
		public int EventId { get; set; }
		[Key(3)]
		public string Name { get; set; }
		[Key(4)]
		public long Hp { get; set; }
		[Key(5)]
		public DateTime StartDate { get; set; }
		[Key(6)]
		public DateTime EndDate { get; set; }
		[Key(7)]
		public int[] SpecificBonusCharacterIds { get; set; }
		[Key(8)]
		public int __CharacterMatchParameterBonusPrimaryKey__ { get; set; }
		[Key(9)]
		public bool UseRandomUnitImage { get; set; }
		[Key(10)]
		public int[] BonusCardIds { get; set; }
		[Key(11)]
		public int[] __CardMatchParameterBonusesPrimaryKey__ { get; set; }
		[Key(12)]
		public int[] DailyRewardMultipliers { get; set; }
		[Key(13)]
		public int OverrideImageNumber { get; set; }
	}
}

