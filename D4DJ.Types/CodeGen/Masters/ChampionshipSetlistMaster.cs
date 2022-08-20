using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ChampionshipSetlistMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __LeaguePrimaryKey__ { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public int DayLimit { get; set; }
		[Key(4)]
		public int[] Charts { get; set; }
	}
}

