using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthActionCardParameterCountMaster
	{
		[Key(0)]
		public int __RarityPrimaryKey__ { get; set; }
		[Key(1)]
		public int Value { get; set; }
	}
}

