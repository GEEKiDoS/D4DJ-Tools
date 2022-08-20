using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ClothMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string ClothName { get; set; }
		[Key(2)]
		public int __CharacterPrimaryKey__ { get; set; }
		[Key(3)]
		public string ClothDescription { get; set; }
		[Key(4)]
		public int DebutOrder { get; set; }
		[Key(5)]
		public DateTime StartDate { get; set; }
		[Key(6)]
		public DateTime EndDate { get; set; }
		[Key(7)]
		public int SourceCardId { get; set; }
	}
}

