using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class SlotEffectMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int EffectId { get; set; }
		[Key(2)]
		public SlotEffectPhase Phase { get; set; }
		[Key(3)]
		public int NormalRate { get; set; }
		[Key(4)]
		public int ChanceTimeRate { get; set; }
		[Key(5)]
		public int ToChanceRate { get; set; }
	}
}

