using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CharacterRankRewardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int CharacterId { get; set; }
		[Key(2)]
		public int CharacterRank { get; set; }
		[Key(3)]
		public RewardCategory Category { get; set; }
		[Key(4)]
		public int RewardId { get; set; }
		[Key(5)]
		public int Amount { get; set; }
		[Key(6)]
		public DateTime StartDate { get; set; }
		[Key(7)]
		public DateTime EndDate { get; set; }
	}
}

