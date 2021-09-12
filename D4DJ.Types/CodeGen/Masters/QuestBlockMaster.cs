using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class QuestBlockMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __MapPrimaryKey__ { get; set; }
		[Key(2)]
		public int Order { get; set; }
		[Key(3)]
		public int __ChartPrimaryKey__ { get; set; }
		[Key(4)]
		public ChartSectionType ChartSection { get; set; }
		[Key(5)]
		public int DeckId { get; set; }
		[Key(6)]
		public int ClubDeckId { get; set; }
		[Key(7)]
		public QuestConditionType ConditionType { get; set; }
		[Key(8)]
		public int ConditionValue { get; set; }
		[Key(9)]
		public int ClubFormationId { get; set; }
		[Key(10)]
		public int DeckPower { get; set; }
		[Key(11)]
		public int __OptionPrimaryKey__ { get; set; }
		[Key(12)]
		public int __AssistOptionPrimaryKey__ { get; set; }
		[Key(13)]
		public int[] __FirstRewardsPrimaryKey__ { get; set; }
		[Key(14)]
		public int[] __LoopRewardsPrimaryKey__ { get; set; }
		[Key(15)]
		public string Name { get; set; }
	}
}

