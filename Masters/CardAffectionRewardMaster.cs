using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
    public class CardAffectionRewardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int AttributeId { get; set; }
		[Key(2)]
		public int CharacterId { get; set; }
		[Key(3)]
		public int RarityId { get; set; }
		[Key(4)]
		public int Affection { get; set; }
		[Key(5)]
		public RewardCategory Category { get; set; }
		[Key(6)]
		public int RewardId { get; set; }
		[Key(7)]
		public int Amount { get; set; }
	}
}
