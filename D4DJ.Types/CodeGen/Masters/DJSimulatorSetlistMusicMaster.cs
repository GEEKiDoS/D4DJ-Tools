using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class DJSimulatorSetlistMusicMaster
	{
		[Key(0)]
		public int __SetlistPrimaryKey__ { get; set; }
		[Key(1)]
		public int Order { get; set; }
		[Key(2)]
		public int __MusicPrimaryKey__ { get; set; }
		[Key(3)]
		public ChartSectionType Section { get; set; }
	}
}

