using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class SummerClothMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int[] CharacterIds { get; set; }
		[Key(2)]
		public DateTime StartDate { get; set; }
		[Key(3)]
		public DateTime EndDate { get; set; }
	}
}

