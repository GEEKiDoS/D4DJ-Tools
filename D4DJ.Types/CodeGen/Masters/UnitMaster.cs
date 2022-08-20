using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class UnitMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public bool CanTraining { get; set; }
		[Key(3)]
		public string[] Summaries { get; set; }
		[Key(4)]
		public string MainColorCode { get; set; }
		[Key(5)]
		public string SubColorCode { get; set; }
		[Key(6)]
		public string ShortName { get; set; }
		[Key(7)]
		public int[] InitDeckCharacterIds { get; set; }
	}
}

