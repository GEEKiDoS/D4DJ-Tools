using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class TowerMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public string Category { get; set; }
		[Key(3)]
		public int[] AvailableCharacterIds { get; set; }
		[Key(4)]
		public int[] AvailableAttributeIds { get; set; }
		[Key(5)]
		public int[] BonusCharacterIds { get; set; }
		[Key(6)]
		public int __CharacterMatchParameterBonusPrimaryKey__ { get; set; }
		[Key(7)]
		public int[] BonusAttributeIds { get; set; }
		[Key(8)]
		public int __AttributeMatchParameterBonusPrimaryKey__ { get; set; }
		[Key(9)]
		public int[] BonusCardIds { get; set; }
		[Key(10)]
		public int[] __CardMatchParameterBonusesPrimaryKey__ { get; set; }
		[Key(11)]
		public DateTime StartDate { get; set; }
		[Key(12)]
		public DateTime EndDate { get; set; }
	}
}

