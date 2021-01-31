using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
    public class CardExpMaster
	{
		[Key(0)]
		public int Level { get; set; }
		[Key(1)]
		public int TotalExp { get; set; }
	}
}
