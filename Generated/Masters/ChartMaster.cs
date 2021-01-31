using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ChartMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __MusicPrimaryKey__ { get; set; }
		[Key(2)]
		public ChartDifficulty Difficulty { get; set; }
		[Key(3)]
		public float Level { get; set; }
		[Key(4)]
		public int AchieveId { get; set; }
		[Key(5)]
		public float[] Trends { get; set; }
		[Key(6)]
		public string OverrideLevel { get; set; }
	}
}

