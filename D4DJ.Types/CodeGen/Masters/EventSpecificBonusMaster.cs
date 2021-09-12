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
		public int CharacterMatchParameterBonusId { get; set; }
		[Key(7)]
		public int CharacterMatchParameterBonusValue { get; set; }
		[Key(8)]
		public int AttributeMatchParameterBonusId { get; set; }
		[Key(9)]
		public int AttributeMatchParameterBonusValue { get; set; }
		[Key(10)]
		public int AllMatchParameterBonusId { get; set; }
		[Key(11)]
		public int AllMatchParameterBonusValue { get; set; }
		[Key(12)]
		public int EventPointParameterBonusId { get; set; }
		[Key(13)]
		public int EventPointParameterBonusRate { get; set; }
	}
}

