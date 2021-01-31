using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MileageMaster
	{
		[Key(0)]
		public MileageRank Rank { get; set; }
		[Key(1)]
		public int NeedMilePoint { get; set; }
	}
}

