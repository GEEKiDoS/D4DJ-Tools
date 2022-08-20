using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ChartNoteCountMaster
	{
		[Key(0)]
		public int ChartId { get; set; }
		[Key(1)]
		public ChartSectionType Section { get; set; }
		[Key(2)]
		public int NormalCount { get; set; }
		[Key(3)]
		public int SimpleCount { get; set; }
	}
}

