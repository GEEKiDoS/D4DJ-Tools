using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class HelpMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __CategoryPrimaryKey__ { get; set; }
		[Key(2)]
		public string Title { get; set; }
		[Key(3)]
		public string ImageUrl { get; set; }
		[Key(4)]
		public string Content { get; set; }
	}
}

