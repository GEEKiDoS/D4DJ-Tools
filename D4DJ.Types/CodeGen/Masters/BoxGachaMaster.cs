using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class BoxGachaMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int[] TableIds { get; set; }
		[Key(3)]
		public int JackpotTableId { get; set; }
		[Key(4)]
		public DateTime StartDate { get; set; }
		[Key(5)]
		public DateTime EndDate { get; set; }
		[Key(6)]
		public int __StockPrimaryKey__ { get; set; }
		[Key(7)]
		public int StockAmount { get; set; }
		[Key(8)]
		public int __CardPrimaryKey__ { get; set; }
	}
}

