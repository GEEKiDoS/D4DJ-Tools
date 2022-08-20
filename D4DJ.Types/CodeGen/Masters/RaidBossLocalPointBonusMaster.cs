using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RaidBossLocalPointBonusMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __GroupPrimaryKey__ { get; set; }
		[Key(2)]
		public int LocalPoint { get; set; }
		[Key(3)]
		public string Name { get; set; }
	}
}

