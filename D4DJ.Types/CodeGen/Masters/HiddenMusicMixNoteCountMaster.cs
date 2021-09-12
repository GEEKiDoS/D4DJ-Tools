using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class HiddenMusicMixNoteCountMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Order { get; set; }
		[Key(2)]
		public ChartDifficulty Difficulty { get; set; }
		[Key(3)]
		public int Count { get; set; }
	}
}

