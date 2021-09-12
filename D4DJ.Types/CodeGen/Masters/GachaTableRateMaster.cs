using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GachaTableRateMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int[] Rates { get; set; }
		[Key(2)]
		public int[] RarityIds { get; set; }
		[Key(3)]
		public string TabName { get; set; }
		[Key(4)]
		public string Description { get; set; }
	}
}

