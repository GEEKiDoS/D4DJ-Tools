using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MobBodyVariantMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Skin { get; set; }
		[Key(2)]
		public int SpineId { get; set; }
	}
}

