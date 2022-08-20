using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class QuestMapMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public DateTime StartDate { get; set; }
		[Key(3)]
		public DateTime EndDate { get; set; }
		[Key(4)]
		public int MaxPlayableCount { get; set; }
		[Key(5)]
		public string BGM { get; set; }
		[Key(6)]
		public string BackgroundPrefabFileName { get; set; }
		[Key(7)]
		public int RecoveryStockId { get; set; }
		[Key(8)]
		public int RecoveryStockAmount { get; set; }
	}
}

