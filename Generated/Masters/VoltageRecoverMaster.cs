using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class VoltageRecoverMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int MinRecoveredCount { get; set; }
		[Key(2)]
		public int DiamondAmount { get; set; }
		[Key(3)]
		public int VoltageRecoverAmount { get; set; }
	}
}

