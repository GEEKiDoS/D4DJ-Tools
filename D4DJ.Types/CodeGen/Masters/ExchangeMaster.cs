using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ExchangeMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public bool IsTabVisible { get; set; }
		[Key(3)]
		public bool IsPollingPlace { get; set; }
		[Key(4)]
		public string CategoryName { get; set; }
		[Key(5)]
		public int Order { get; set; }
	}
}

