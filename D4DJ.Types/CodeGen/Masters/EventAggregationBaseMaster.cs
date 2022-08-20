using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventAggregationBaseMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(2)]
		public EventAggregationType AggregationType { get; set; }
		[Key(3)]
		public string PointTypeName { get; set; }
		[Key(4)]
		public string PointTypeIconName { get; set; }
		[Key(5)]
		public int EventPointRewardTemplateId { get; set; }
		[Key(6)]
		public int EventRankingRewardTemplateId { get; set; }
	}
}

