using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MissionDetailMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __PanelPrimaryKey__ { get; set; }
		[Key(2)]
		public int Sequence { get; set; }
		[Key(3)]
		public string Title { get; set; }
		[Key(4)]
		public string Description { get; set; }
		[Key(5)]
		public int ConditionId { get; set; }
		[Key(6)]
		public int[] ConditionValues { get; set; }
		[Key(7)]
		public int[] __RewardsPrimaryKey__ { get; set; }
		[Key(8)]
		public int __CommandMasterPrimaryKey__ { get; set; }
		[Key(9)]
		public int HomePriority { get; set; }
		[Key(10)]
		public AchievementNotifyType NotifyType { get; set; }
	}
}

