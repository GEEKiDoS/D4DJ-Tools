using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ChartAchieveMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public ChartAchieveType Type { get; set; }
		[Key(2)]
		public int Value { get; set; }
		[Key(3)]
		public int __RewardStockPrimaryKey__ { get; set; }
		[Key(4)]
		public int RewardAmount { get; set; }
	}
}

