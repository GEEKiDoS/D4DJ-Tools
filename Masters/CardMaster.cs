using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
    public class CardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __RarityPrimaryKey__ { get; set; }
		[Key(2)]
		public string CardName { get; set; }
		[Key(3)]
		public int __AttributePrimaryKey__ { get; set; }
		[Key(4)]
		public int __CharacterPrimaryKey__ { get; set; }
		[Key(5)]
		public int __SkillParameterPrimaryKey__ { get; set; }
		[Key(6)]
		public string SkillName { get; set; }
		[Key(7)]
		public int[] MaxParameters { get; set; }
		[Key(8)]
		public string GachaMessage { get; set; }
		[Key(9)]
		public int ClothCardId { get; set; }
		[Key(10)]
		public int DebutOrder { get; set; }
		[Key(11)]
		public float[] CardIllustHeadDistanceY { get; set; }
		[Key(12)]
		public float[] CardIllustCenterDistanceX { get; set; }
		[Key(13)]
		public DateTime StartDate { get; set; }
		[Key(14)]
		public DateTime EndDate { get; set; }
	}
}
