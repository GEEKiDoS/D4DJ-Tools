using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthBlockMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public GrowthBlockCategory BlockType { get; set; }
		[Key(2)]
		public int[] __EffectSetPrimaryKey__ { get; set; }
	}
}

