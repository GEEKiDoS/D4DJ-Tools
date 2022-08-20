using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class StampMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public StampCategory Category { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public string Description { get; set; }
		[Key(4)]
		public bool HasVoice { get; set; }
		[Key(5)]
		public int DuplicateId { get; set; }
	}
}

