using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class Live2DUIChatMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public Live2DUIChatCategory[] Categories { get; set; }
		[Key(2)]
		public int __CharacterPrimaryKey__ { get; set; }
		[Key(3)]
		public int ClothId { get; set; }
		[Key(4)]
		public string Message { get; set; }
		[Key(5)]
		public string Motion { get; set; }
		[Key(6)]
		public DateTime StartDate { get; set; }
		[Key(7)]
		public DateTime EndDate { get; set; }
	}
}

