using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class PassiveSkillDescriptionMaster
	{
		[Key(0)]
		public PassiveSkillType Type { get; set; }
		[Key(1)]
		public string Description { get; set; }
	}
}

