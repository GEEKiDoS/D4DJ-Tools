using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class UserExpMaster
	{
		[Key(0)]
		public int Level { get; set; }
		[Key(1)]
		public int TotalExp { get; set; }
		[Key(2)]
		public int RecoveryVoltage { get; set; }
		[Key(3)]
		public int MaxFriendCount { get; set; }
		[Key(4)]
		public int DeckSupportCardNum { get; set; }
		[Key(5)]
		public string AdjustEventToken { get; set; }
		[Key(6)]
		public string FirebaseEventName { get; set; }
	}
}

