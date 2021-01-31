using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MissionGroupMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public MissionCategory Category { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public DateTime StartDate { get; set; }
		[Key(4)]
		public DateTime EndDate { get; set; }
		[Key(5)]
		public DateSelectCategory ResetType { get; set; }
		[Key(6)]
		public int ResetValue { get; set; }
		[Key(7)]
		public int SubscriptionId { get; set; }
	}
}

