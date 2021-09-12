using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CardDisplayMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int GroupId { get; set; }
		[Key(2)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(3)]
		public CardIllustType CardType { get; set; }
		[Key(4)]
		public int Rate { get; set; }
	}
}

