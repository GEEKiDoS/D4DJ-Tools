using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class TowerStageMaster
	{
		[Key(0)]
		public int __TowerPrimaryKey__ { get; set; }
		[Key(1)]
		public int Order { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public int[] __MusicsPrimaryKey__ { get; set; }
		[Key(4)]
		public int TargetScore { get; set; }
		[Key(5)]
		public int[] __RewardsPrimaryKey__ { get; set; }
	}
}

