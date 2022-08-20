using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthBlockEffectSetMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int[] __EffectDetailsPrimaryKey__ { get; set; }
		[Key(2)]
		public int BlockChance { get; set; }
	}
}

