using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ExchangeMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public bool IsTabVisible { get; set; }
		[Key(3)]
		public bool IsPollingPlace { get; set; }
		[Key(4)]
		public string CategoryName { get; set; }
		[Key(5)]
		public int Order { get; set; }
		[Key(6)]
		public bool IsSecret { get; set; }
		[Key(7)]
		public string SecretName { get; set; }
		[Key(8)]
		public int DeliveryEffectId { get; set; }
		[Key(9)]
		public DateTime DeliveryDate { get; set; }
		[Key(10)]
		public bool ShowPollingGauge { get; set; }
		[Key(11)]
		public string[] GaugeColorCodes { get; set; }
	}
}

