using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools
{
	public class TokenAttribute : Attribute
	{
		public string Token;
	}

	public class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
}
