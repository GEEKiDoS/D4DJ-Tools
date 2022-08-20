using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MapMobMaster
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
		public int Motion { get; set; }
		[Key(5)]
		public int Direction { get; set; }
		[Key(6)]
		public int Skin { get; set; }
		[Key(7)]
		public MobMovingPattern MovingPattern { get; set; }
		[Key(8)]
		public float MovingDuration { get; set; }
		[Key(9)]
		public float DelaySeconds { get; set; }
		[Key(10)]
		public int WayPoint1X { get; set; }
		[Key(11)]
		public int WayPoint1Y { get; set; }
		[Key(12)]
		public int WayPoint2X { get; set; }
		[Key(13)]
		public int WayPoint2Y { get; set; }
		[Key(14)]
		public int WayPoint3X { get; set; }
		[Key(15)]
		public int WayPoint3Y { get; set; }
		[Key(16)]
		public int WayPoint4X { get; set; }
		[Key(17)]
		public int WayPoint4Y { get; set; }
		[Key(18)]
		public int WayPoint5X { get; set; }
		[Key(19)]
		public int WayPoint5Y { get; set; }
		[Key(20)]
		public int CharacterId { get; set; }
		[Key(21)]
		public DateTime StartDate { get; set; }
		[Key(22)]
		public DateTime EndDate { get; set; }
	}
}

