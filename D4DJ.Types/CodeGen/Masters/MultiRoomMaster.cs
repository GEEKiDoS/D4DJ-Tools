using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MultiRoomMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public MultiRoomType RoomType { get; set; }
		[Key(2)]
		public LiveType Type { get; set; }
		[Key(3)]
		public string Name { get; set; }
		[Key(4)]
		public string Description { get; set; }
		[Key(5)]
		public int MinimumDeckPower { get; set; }
		[Key(6)]
		public float Multiplier { get; set; }
		[Key(7)]
		public bool ForceAssistOff { get; set; }
		[Key(8)]
		public bool IsRaidRoom { get; set; }
	}
}

