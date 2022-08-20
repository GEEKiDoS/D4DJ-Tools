using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ParameterBonusMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int TargetId { get; set; }
		[Key(2)]
		public int Value { get; set; }
	}
}

