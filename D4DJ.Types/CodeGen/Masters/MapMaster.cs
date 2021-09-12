using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MapMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int PositionX { get; set; }
		[Key(3)]
		public int PositionY { get; set; }
		[Key(4)]
		public int[] __ConditionsPrimaryKey__ { get; set; }
		[Key(5)]
		public string BGM { get; set; }
		[Key(6)]
		public float CharacterScale { get; set; }
		[Key(7)]
		public DateTime StartDate { get; set; }
		[Key(8)]
		public DateTime EndDate { get; set; }
		[Key(9)]
		public int ADVBackgroundId { get; set; }
		[Key(10)]
		public bool ForceDefaultMap { get; set; }
	}
}

