using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class PassiveSkillMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public PassiveSkillType Type { get; set; }
		[Key(2)]
		public float MinValue { get; set; }
		[Key(3)]
		public float MaxValue { get; set; }
		[Key(4)]
		public float SubValue { get; set; }
	}
}

