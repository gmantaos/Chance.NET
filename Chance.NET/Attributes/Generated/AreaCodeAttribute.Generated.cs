using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class AreaCodeAttribute : ChanceAttribute
	{
		Boolean parentheses = true;


		public AreaCodeAttribute(Boolean parentheses = true)
		{
			this.parentheses = parentheses;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.AreaCode(parentheses);
		}
	}
}
