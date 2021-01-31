using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GachaTableMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int TableId { get; set; }
		[Key(2)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(3)]
		public int Rate { get; set; }
	}
}

