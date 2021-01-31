using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class LiveResultEpisodeMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int[] __CharactersPrimaryKey__ { get; set; }
	}
}

