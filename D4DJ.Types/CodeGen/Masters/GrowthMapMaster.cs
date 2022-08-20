using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthMapMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int[] __TemplatesPrimaryKey__ { get; set; }
	}
}

