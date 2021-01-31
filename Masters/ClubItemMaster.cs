using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
