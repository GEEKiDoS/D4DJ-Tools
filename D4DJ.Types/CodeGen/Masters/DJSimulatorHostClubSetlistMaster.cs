using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class DJSimulatorHostClubSetlistMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __UnitPrimaryKey__ { get; set; }
		[Key(2)]
		public int GroupIndex { get; set; }
		[Key(3)]
		public int __ClubItemPrimaryKey__ { get; set; }
	}
}

