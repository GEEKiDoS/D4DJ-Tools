using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MapObjectSpotMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __MapPrimaryKey__ { get; set; }
		[Key(2)]
		public int PositionX { get; set; }
		[Key(3)]
		public int PositionY { get; set; }
		[Key(4)]
		public MapObjectType ObjectType { get; set; }
	}
}

