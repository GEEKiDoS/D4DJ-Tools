using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class HonorMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public HonorType Type { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public string Description { get; set; }
	}
}

