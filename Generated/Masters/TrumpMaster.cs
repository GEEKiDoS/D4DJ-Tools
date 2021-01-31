using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class TrumpMaster
	{
		[Key(0)]
		public TrumpSuit Suit { get; set; }
		[Key(1)]
		public int Id { get; set; }
		[Key(2)]
		public int ImageId { get; set; }
		[Key(3)]
		public int Pose { get; set; }
	}
}

