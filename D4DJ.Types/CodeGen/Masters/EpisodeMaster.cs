using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EpisodeMaster
	{
		[Key(0)]
		public EpisodeCategory Category { get; set; }
		[Key(1)]
		public int Id { get; set; }
		[Key(2)]
		public int[] __ConditionsPrimaryKey__ { get; set; }
		[Key(3)]
		public string Title { get; set; }
		[Key(4)]
		public string Summary { get; set; }
		[Key(5)]
		public int[] __RewardsPrimaryKey__ { get; set; }
		[Key(6)]
		public DateTime StartDate { get; set; }
		[Key(7)]
		public DateTime EndDate { get; set; }
		[Key(8)]
		public bool HasVoice { get; set; }
	}
}

