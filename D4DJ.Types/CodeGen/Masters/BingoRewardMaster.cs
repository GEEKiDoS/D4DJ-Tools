using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class BingoRewardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int RewardPhaseId { get; set; }
		[Key(2)]
		public BingoRewardCategory Category { get; set; }
		[Key(3)]
		public int MaxCount { get; set; }
		[Key(4)]
		public RewardCategory RewardCategory { get; set; }
		[Key(5)]
		public int RewardId { get; set; }
		[Key(6)]
		public int RewardAmount { get; set; }
	}
}

