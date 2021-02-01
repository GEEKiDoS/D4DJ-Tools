using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ClubItemDetailMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Level { get; set; }
		[Key(2)]
		public ClubItemTargetType TargetType { get; set; }
		[Key(3)]
		public int TargetId { get; set; }
		[Key(4)]
		public float EffectValue { get; set; }
		[Key(5)]
		public int[] __ConditionsPrimaryKey__ { get; set; }
		[Key(6)]
		public int RequiredStockId1 { get; set; }
		[Key(7)]
		public int RequiredAmount1 { get; set; }
		[Key(8)]
		public int RequiredStockId2 { get; set; }
		[Key(9)]
		public int RequiredAmount2 { get; set; }
		[Key(10)]
		public int RequiredStockId3 { get; set; }
		[Key(11)]
		public int RequiredAmount3 { get; set; }
		[Key(12)]
		public int RequiredStockId4 { get; set; }
		[Key(13)]
		public int RequiredAmount4 { get; set; }
		[Key(14)]
		public int RequiredStockId5 { get; set; }
		[Key(15)]
		public int RequiredAmount5 { get; set; }
	}
}

