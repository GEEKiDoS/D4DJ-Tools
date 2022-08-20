using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CampaignButtonMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Command { get; set; }
		[Key(2)]
		public DateTime StartDate { get; set; }
		[Key(3)]
		public DateTime EndDate { get; set; }
		[Key(4)]
		public string Text { get; set; }
		[Key(5)]
		public string ImageFileName { get; set; }
		[Key(6)]
		public CampaignButtonDisplayLocation DisplayLocation { get; set; }
	}
}

