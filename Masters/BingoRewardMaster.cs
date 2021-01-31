using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
    public class BingoLotPointMaster
	{
		[Key(0)]
		public int MinCardNumber { get; set; }
		[Key(1)]
		public int LotNumberNeedPoint { get; set; }
	}
}
