using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CampaignMaster
	{
		[Key(0)]
		public CampaignCategory Category { get; set; }
		[Key(1)]
		public float Rate { get; set; }
		[Key(2)]
		public DateTime StartDate { get; set; }
		[Key(3)]
		public DateTime EndDate { get; set; }
	}
}

