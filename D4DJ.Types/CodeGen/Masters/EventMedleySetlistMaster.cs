using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventMedleySetlistMaster
	{
		[Key(0)]
		public int __AggregationPrimaryKey__ { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int[] MusicIds { get; set; }
		[Key(3)]
		public int RequiredPoint { get; set; }
		[Key(4)]
		public DateTime StartDate { get; set; }
		[Key(5)]
		public DateTime EndDate { get; set; }
		[Key(6)]
		public int Order { get; set; }
		[Key(7)]
		public int[] SpecificBonusCharacterIds { get; set; }
		[Key(8)]
		public int CharacterMatchParameterBonusId { get; set; }
		[Key(9)]
		public int CharacterMatchParameterBonusValue { get; set; }
	}
}

