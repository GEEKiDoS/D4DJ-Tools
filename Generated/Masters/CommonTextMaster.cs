using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CommonTextMaster
	{
		[Key(0)]
		public CommonTextType Id { get; set; }
		[Key(1)]
		public string Text { get; set; }
	}
}

