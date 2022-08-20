using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthSpecificBonusMaster
	{
		[Key(0)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(1)]
		public int[] __CardIdsPrimaryKey__ { get; set; }
		[Key(2)]
		public int BonusRate { get; set; }
	}
}

