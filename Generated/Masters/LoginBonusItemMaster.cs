using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class LoginBonusItemMaster
	{
		[Key(0)]
		public int __LoginBonusPrimaryKey__ { get; set; }
		[Key(1)]
		public int Sequence { get; set; }
		[Key(2)]
		public int[] __RewardsPrimaryKey__ { get; set; }
		[Key(3)]
		public int[] Positions { get; set; }
	}
}

