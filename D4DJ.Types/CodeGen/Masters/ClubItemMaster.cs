using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ClubItemMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int GroupId { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public string Description { get; set; }
		[Key(4)]
		public int __SpotPrimaryKey__ { get; set; }
		[Key(5)]
		public int DetailId { get; set; }
		[Key(6)]
		public int __CategoryPrimaryKey__ { get; set; }
		[Key(7)]
		public int ConditionCardId { get; set; }
		[Key(8)]
		public DateTime StartDate { get; set; }
		[Key(9)]
		public DateTime EndDate { get; set; }
		[Key(10)]
		public int DuplicateId { get; set; }
		[Key(11)]
		public string SearchWords { get; set; }
	}
}

