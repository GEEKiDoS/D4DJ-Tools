using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MapEventMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __MapPrimaryKey__ { get; set; }
		[Key(2)]
		public int[] __CharactersPrimaryKey__ { get; set; }
		[Key(3)]
		public int[] Motions { get; set; }
		[Key(4)]
		public int[] Directions { get; set; }
		[Key(5)]
		public int[] Skins { get; set; }
		[Key(6)]
		public MapEventType EventType { get; set; }
		[Key(7)]
		public int[] SummerSkins { get; set; }
	}
}

