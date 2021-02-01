using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MissionPanelMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __GroupPrimaryKey__ { get; set; }
		[Key(2)]
		public int BannerGroup { get; set; }
		[Key(3)]
		public int Step { get; set; }
		[Key(4)]
		public string Name { get; set; }
		[Key(5)]
		public int[] __AllCompleteRewardsPrimaryKey__ { get; set; }
	}
}

