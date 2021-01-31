using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CommonValueMaster
	{
		[Key(0)]
		public CommonValueType Id { get; set; }
		[Key(1)]
		public int Value { get; set; }
	}
}

