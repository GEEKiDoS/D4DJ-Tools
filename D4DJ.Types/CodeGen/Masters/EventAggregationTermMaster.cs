using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventAggregationTermMaster
	{
		[Key(0)]
		public int AggregationId { get; set; }
		[Key(1)]
		public DateTime StartDate { get; set; }
		[Key(2)]
		public DateTime ReceptionCloseDate { get; set; }
		[Key(3)]
		public DateTime RankFixStartDate { get; set; }
		[Key(4)]
		public DateTime ResultAnnouncementDate { get; set; }
	}
}

