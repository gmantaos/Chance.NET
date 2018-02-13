using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class D100Attribute : ChanceAttribute
	{


		public D100Attribute()
		{

		}

		internal override object GetValue(Chance chance)
		{
			return chance.D100();
		}
	}
}
