using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CharacterMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string FullName { get; set; }
		[Key(2)]
		public string FirstName { get; set; }
		[Key(3)]
		public string FirstNameEnglish { get; set; }
		[Key(4)]
		public int __UnitPrimaryKey__ { get; set; }
		[Key(5)]
		public string[] ProfileAnswers { get; set; }
		[Key(6)]
		public string FullNameEnglish { get; set; }
		[Key(7)]
		public string ColorCode { get; set; }
	}
}

