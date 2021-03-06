using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class BingoVoiceMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int CharacterId { get; set; }
		[Key(2)]
		public BingoStatusCategory BingoStatus { get; set; }
		[Key(3)]
		public int AchieveNum { get; set; }
	}
}

