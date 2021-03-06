using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class AgeAttribute : ChanceAttribute
	{
		AgeRanges range = (AgeRanges)~0;


		public AgeAttribute(AgeRanges range = (AgeRanges)~0)
		{
			this.range = range;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Age(range);
		}
	}
}
