using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MapSpotMaster
	{
		[Key(0)]
		public int __MapPrimaryKey__ { get; set; }
		[Key(1)]
		public int SpotId { get; set; }
		[Key(2)]
		public int Position1X { get; set; }
		[Key(3)]
		public int Position1Y { get; set; }
		[Key(4)]
		public int Position2X { get; set; }
		[Key(5)]
		public int Position2Y { get; set; }
		[Key(6)]
		public int Position3X { get; set; }
		[Key(7)]
		public int Position3Y { get; set; }
		[Key(8)]
		public int Position4X { get; set; }
		[Key(9)]
		public int Position4Y { get; set; }
		[Key(10)]
		public int Position5X { get; set; }
		[Key(11)]
		public int Position5Y { get; set; }
		[Key(12)]
		public DateTime StartDate { get; set; }
		[Key(13)]
		public DateTime EndDate { get; set; }
	}
}

