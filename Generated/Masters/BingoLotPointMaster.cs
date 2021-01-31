using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class BingoLotPointMaster
	{
		[Key(0)]
		public int MinCardNumber { get; set; }
		[Key(1)]
		public int LotNumberNeedPoint { get; set; }
	}
}

