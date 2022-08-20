using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventPointRewardTemplateMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int TemplateId { get; set; }
		[Key(2)]
		public int RequiredPoint { get; set; }
		[Key(3)]
		public RewardCategory Category { get; set; }
		[Key(4)]
		public int RewardId { get; set; }
		[Key(5)]
		public int Amount { get; set; }
	}
}

