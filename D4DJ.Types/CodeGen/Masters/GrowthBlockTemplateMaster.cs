using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthBlockTemplateMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Len { get; set; }
		[Key(2)]
		public int Point1 { get; set; }
		[Key(3)]
		public int Point2 { get; set; }
		[Key(4)]
		public int Point3 { get; set; }
		[Key(5)]
		public int Point4 { get; set; }
		[Key(6)]
		public int Point5 { get; set; }
		[Key(7)]
		public int Point6 { get; set; }
		[Key(8)]
		public int Point7 { get; set; }
		[Key(9)]
		public int Point8 { get; set; }
		[Key(10)]
		public int Point9 { get; set; }
		[Key(11)]
		public int Point10 { get; set; }
	}
}

