using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ChartLessonMaster
	{
		[Key(0)]
		public int ChartId { get; set; }
		[Key(1)]
		public int MeasureIndex { get; set; }
		[Key(2)]
		public string Text { get; set; }
		[Key(3)]
		public string[] ImagePaths { get; set; }
	}
}

