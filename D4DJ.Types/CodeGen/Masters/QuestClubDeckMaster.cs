using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class QuestClubDeckMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __SpotPrimaryKey__ { get; set; }
		[Key(2)]
		public int __ItemPrimaryKey__ { get; set; }
		[Key(3)]
		public bool UseSpecialEffect { get; set; }
	}
}

