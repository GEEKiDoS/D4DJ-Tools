using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthCharacterBlockMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __CharacterIdPrimaryKey__ { get; set; }
		[Key(2)]
		public GrowthBlockEffectType[] CharacterEffectType { get; set; }
		[Key(3)]
		public int[] EffectValues { get; set; }
		[Key(4)]
		public EffectTypeOperator[] EffectTypeOperator { get; set; }
		[Key(5)]
		public int Image { get; set; }
	}
}

