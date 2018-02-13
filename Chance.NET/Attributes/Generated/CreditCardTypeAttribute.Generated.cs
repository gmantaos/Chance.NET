using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class CreditCardTypeAttribute : ChanceAttribute
	{
		CreditCardTypes? types;


		public CreditCardTypeAttribute(CreditCardTypes? types = null)
		{
			this.types = types;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.CreditCardType(types);
		}
	}
}
