using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class LoginBonusPositionTemplateMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Sequence { get; set; }
		[Key(2)]
		public int[] Positions { get; set; }
	}
}

