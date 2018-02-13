using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class BoolAttribute : ChanceAttribute
	{
		Double likelihood;


		public BoolAttribute(Double likelihood)
		{
			this.likelihood = likelihood;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Bool(likelihood);
		}
	}
}
