using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ParameterLevelMaster
	{
		[Key(0)]
		public int Level { get; set; }
		[Key(1)]
		public int NeedsCharacterRank { get; set; }
		[Key(2)]
		public float EffectValue { get; set; }
		[Key(3)]
		public int TotalExp { get; set; }
	}
}

