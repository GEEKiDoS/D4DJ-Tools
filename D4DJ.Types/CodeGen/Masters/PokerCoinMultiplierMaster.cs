using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class PokerCoinMultiplierMaster
	{
		[Key(0)]
		public PokerHandCategory Hand { get; set; }
		[Key(1)]
		public float Multiplier { get; set; }
	}
}

