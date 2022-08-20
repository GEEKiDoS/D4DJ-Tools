using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class LiveSEMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __LiveSEPackMasterPrimaryKey__ { get; set; }
		[Key(2)]
		public LiveSECategory Category { get; set; }
		[Key(3)]
		public string Name { get; set; }
		[Key(4)]
		public bool IsPreset { get; set; }
	}
}

