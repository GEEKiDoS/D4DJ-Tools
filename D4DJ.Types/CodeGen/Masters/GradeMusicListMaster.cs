using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GradeMusicListMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __SeasonPrimaryKey__ { get; set; }
		[Key(2)]
		public int Grade { get; set; }
		[Key(3)]
		public string Name { get; set; }
		[Key(4)]
		public int MaxHP { get; set; }
		[Key(5)]
		public int[] EvaluationRate { get; set; }
		[Key(6)]
		public int[] Charts { get; set; }
		[Key(7)]
		public int[] IsHidden { get; set; }
		[Key(8)]
		public int __MissionPrimaryKey__ { get; set; }
	}
}

