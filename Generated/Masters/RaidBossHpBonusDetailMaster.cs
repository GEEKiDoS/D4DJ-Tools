using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RaidBossHpBonusDetailMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int BonusId { get; set; }
		[Key(2)]
		public int RewardStockId { get; set; }
		[Key(3)]
		public int RewardAmount { get; set; }
	}
}

