using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthBlockEffectDetailMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public GrowthBlockEffectType EffectType { get; set; }
		[Key(2)]
		public EffectTargetType EffectTargetType { get; set; }
		[Key(3)]
		public int EffectTargetValue { get; set; }
		[Key(4)]
		public int EffectTypeValue { get; set; }
		[Key(5)]
		public EffectTypeOperator EffectTypeOperator { get; set; }
		[Key(6)]
		public int EffectChance { get; set; }
	}
}

