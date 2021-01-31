using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public EventType Type { get; set; }
		[Key(3)]
		public DateTime StartDate { get; set; }
		[Key(4)]
		public DateTime ReceptionCloseDate { get; set; }
		[Key(5)]
		public DateTime RankFixStartDate { get; set; }
		[Key(6)]
		public DateTime ResultAnnouncementDate { get; set; }
		[Key(7)]
		public DateTime EndDate { get; set; }
		[Key(8)]
		public int StockId { get; set; }
		[Key(9)]
		public int EntryBonusStockAmount { get; set; }
		[Key(10)]
		public int StockAmountPerUse { get; set; }
		[Key(11)]
		public int[] EpisodeCharacters { get; set; }
		[Key(12)]
		public int __DisplayCardPrimaryKey__ { get; set; }
		[Key(13)]
		public CardIllustType DisplayCardType { get; set; }
		[Key(14)]
		public DateTime StoryUnlockDate { get; set; }
	}
}

