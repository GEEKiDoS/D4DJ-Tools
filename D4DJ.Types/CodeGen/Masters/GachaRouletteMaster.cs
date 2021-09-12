using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GachaRouletteMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public GachaRouletteType Type { get; set; }
		[Key(2)]
		public int TargetId { get; set; }
		[Key(3)]
		public int EffectValue { get; set; }
		[Key(4)]
		public int DrawLimit { get; set; }
	}
}

