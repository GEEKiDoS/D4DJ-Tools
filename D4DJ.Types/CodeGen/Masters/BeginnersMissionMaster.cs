using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class BeginnersMissionMaster
	{
		[Key(0)]
		public int __DetailPrimaryKey__ { get; set; }
		[Key(1)]
		public string Hint { get; set; }
		[Key(2)]
		public bool IsRecommend { get; set; }
		[Key(3)]
		public bool IsTutorialEnd { get; set; }
	}
}

