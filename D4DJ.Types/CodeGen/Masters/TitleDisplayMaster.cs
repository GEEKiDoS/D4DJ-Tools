using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class TitleDisplayMaster
	{
		[Key(0)]
		public int CardDisplayGroupId { get; set; }
		[Key(1)]
		public DateTime StartDate { get; set; }
		[Key(2)]
		public DateTime EndDate { get; set; }
		[Key(3)]
		public int TitleBGMCueId { get; set; }
		[Key(4)]
		public string TitleVoiceCueName { get; set; }
		[Key(5)]
		public string TitleVoiceCueName2 { get; set; }
	}
}

