using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventEpisodeMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int BackgroundId { get; set; }
		[Key(2)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(3)]
		public int ChapterNumber { get; set; }
	}
}

