using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class TitleDisplayMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(2)]
		public CardIllustType CardType { get; set; }
		[Key(3)]
		public int Rate { get; set; }
		[Key(4)]
		public DateTime StartDate { get; set; }
		[Key(5)]
		public DateTime EndDate { get; set; }
	}
}

