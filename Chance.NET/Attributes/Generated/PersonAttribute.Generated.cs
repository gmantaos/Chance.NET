using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class PersonAttribute : ChanceAttribute
	{
		AgeRanges ageRange;
		Gender? gender;


		public PersonAttribute(AgeRanges ageRange = AgeRanges.Any, Gender? gender = null)
		{
			this.ageRange = ageRange;
			this.gender = gender;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Person(ageRange, gender);
		}
	}
}