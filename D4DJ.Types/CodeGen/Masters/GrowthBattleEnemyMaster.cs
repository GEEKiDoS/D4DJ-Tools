using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthBattleEnemyMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int ConditionValue { get; set; }
		[Key(2)]
		public int[] EnemyCharacterIds { get; set; }
		[Key(3)]
		public int Sequence { get; set; }
	}
}

