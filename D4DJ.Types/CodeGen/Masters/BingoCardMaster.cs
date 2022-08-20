using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class BingoCardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int MinCardNumber { get; set; }
		[Key(2)]
		public int LotNumberNeedPoint { get; set; }
		[Key(3)]
		public int RewardPhaseId { get; set; }
		[Key(4)]
		public int[] CardImageIDs { get; set; }
		[Key(5)]
		public BingoCardType CardType { get; set; }
	}
}

