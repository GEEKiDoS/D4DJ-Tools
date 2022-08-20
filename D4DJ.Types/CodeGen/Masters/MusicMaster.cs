using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MusicMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public string ReadName { get; set; }
		[Key(3)]
		public string Lyrist { get; set; }
		[Key(4)]
		public string Composer { get; set; }
		[Key(5)]
		public string Arranger { get; set; }
		[Key(6)]
		public string SpecialUnitName { get; set; }
		[Key(7)]
		public MusicCategory Category { get; set; }
		[Key(8)]
		public int __UnitPrimaryKey__ { get; set; }
		[Key(9)]
		public int DefaultOrder { get; set; }
		[Key(10)]
		public float MusicBpm { get; set; }
		[Key(11)]
		public int OpenKey { get; set; }
		[Key(12)]
		public ChartSectionType SectionTrend { get; set; }
		[Key(13)]
		public DateTime StartDate { get; set; }
		[Key(14)]
		public DateTime EndDate { get; set; }
		[Key(15)]
		public bool HasMovie { get; set; }
		[Key(16)]
		public int[] __PurchaseBonusesPrimaryKey__ { get; set; }
		[Key(17)]
		public bool IsHidden { get; set; }
		[Key(18)]
		public bool ExcludeChallenge { get; set; }
		[Key(19)]
		public bool CanFairUse { get; set; }
		[Key(20)]
		public DateTime UnlockDate { get; set; }
	}
}

