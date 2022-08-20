using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RarityMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int[] MaxLevels { get; set; }
		[Key(2)]
		public float[] MaxLevelParameterRates { get; set; }
		[Key(3)]
		public int[] LimitBreakBonuses { get; set; }
		[Key(4)]
		public int SealAmount { get; set; }
		[Key(5)]
		public int[] CardStackBonuses { get; set; }
	}
}

