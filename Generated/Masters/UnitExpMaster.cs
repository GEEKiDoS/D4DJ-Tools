using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class UnitExpMaster
	{
		[Key(0)]
		public int Level { get; set; }
		[Key(1)]
		public int TotalExp { get; set; }
	}
}

