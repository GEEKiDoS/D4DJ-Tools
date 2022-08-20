using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventSpecificBonusMaster
	{
		[Key(0)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(1)]
		public int[] CharacterIds { get; set; }
		[Key(2)]
		public int AttributeId { get; set; }
		[Key(3)]
		public int CharacterMatchPointBonusValue { get; set; }
		[Key(4)]
		public int AttributeMatchPointBonusValue { get; set; }
		[Key(5)]
		public int AllMatchPointBonusValue { get; set; }
		[Key(6)]
		public int __CharacterMatchParameterBonusPrimaryKey__ { get; set; }
		[Key(7)]
		public int __AttributeMatchParameterBonusPrimaryKey__ { get; set; }
		[Key(8)]
		public int __AllMatchParameterBonusPrimaryKey__ { get; set; }
		[Key(9)]
		public int EventPointParameterBonusId { get; set; }
		[Key(10)]
		public int EventPointParameterBonusRate { get; set; }
	}
}

