using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class QuestDeckMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Order { get; set; }
		[Key(2)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(3)]
		public CardIllustType IllustType { get; set; }
	}
}

