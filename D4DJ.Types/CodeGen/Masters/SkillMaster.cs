using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class SkillMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int MinRecoveryValue { get; set; }
		[Key(2)]
		public int MaxRecoveryValue { get; set; }
		[Key(3)]
		public int ComboSupportCount { get; set; }
		[Key(4)]
		public int ScoreUpRate { get; set; }
		[Key(5)]
		public float MinSeconds { get; set; }
		[Key(6)]
		public float MaxSeconds { get; set; }
		[Key(7)]
		public int PerfectScoreUpRate { get; set; }
	}
}

