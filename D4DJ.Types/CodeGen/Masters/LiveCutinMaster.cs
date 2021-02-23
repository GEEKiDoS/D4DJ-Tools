using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class LiveCutinMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int CharacterId1 { get; set; }
		[Key(2)]
		public string Motion1 { get; set; }
		[Key(3)]
		public int CharacterId2 { get; set; }
		[Key(4)]
		public string Motion2 { get; set; }
		[Key(5)]
		public int CharacterId3 { get; set; }
		[Key(6)]
		public string Motion3 { get; set; }
		[Key(7)]
		public int[] __ConditionsPrimaryKey__ { get; set; }
		[Key(8)]
		public DateTime StartDate { get; set; }
		[Key(9)]
		public DateTime EndDate { get; set; }
	}
}

