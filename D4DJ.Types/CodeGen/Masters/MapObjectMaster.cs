using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MapObjectMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __SpotPrimaryKey__ { get; set; }
		[Key(2)]
		public string FileName { get; set; }
		[Key(3)]
		public int RandomWeight { get; set; }
		[Key(4)]
		public DateTime StartDate { get; set; }
		[Key(5)]
		public DateTime EndDate { get; set; }
		[Key(6)]
		public string ButtonText1 { get; set; }
		[Key(7)]
		public string ButtonHref1 { get; set; }
		[Key(8)]
		public string ButtonText2 { get; set; }
		[Key(9)]
		public string ButtonHref2 { get; set; }
		[Key(10)]
		public string ButtonText3 { get; set; }
		[Key(11)]
		public string ButtonHref3 { get; set; }
	}
}

