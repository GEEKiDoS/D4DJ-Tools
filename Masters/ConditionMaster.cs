using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
    public class ConditionMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public ConditionCategory Category { get; set; }
		[Key(2)]
		public int[] Value { get; set; }
	}
}
