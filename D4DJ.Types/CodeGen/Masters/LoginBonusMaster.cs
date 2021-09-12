using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class LoginBonusMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public LoginBonusType Type { get; set; }
		[Key(2)]
		public string Title { get; set; }
		[Key(3)]
		public int Order { get; set; }
		[Key(4)]
		public bool Loop { get; set; }
		[Key(5)]
		public DateTime StartDate { get; set; }
		[Key(6)]
		public DateTime EndDate { get; set; }
		[Key(7)]
		public int SubscriptionId { get; set; }
		[Key(8)]
		public string BackgroundImage { get; set; }
		[Key(9)]
		public string ForegroundImage { get; set; }
		[Key(10)]
		public int[] DatePositions { get; set; }
		[Key(11)]
		public int LimitDays { get; set; }
	}
}

