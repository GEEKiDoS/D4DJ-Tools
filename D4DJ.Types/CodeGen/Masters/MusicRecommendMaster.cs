using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MusicRecommendMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Description { get; set; }
		[Key(2)]
		public bool IsClientOnly { get; set; }
		[Key(3)]
		public bool IsChooseAbsolutely { get; set; }
		[Key(4)]
		public bool IsInsurance { get; set; }
	}
}

