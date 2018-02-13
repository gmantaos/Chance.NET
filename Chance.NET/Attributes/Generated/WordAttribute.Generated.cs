using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class WordAttribute : ChanceAttribute
	{
		Int32? syllables;
		Int32? length;
		Boolean capitalize;


		public WordAttribute(Int32? syllables = null, Int32? length = null, Boolean capitalize = false)
		{
			this.syllables = syllables;
			this.length = length;
			this.capitalize = capitalize;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Word(syllables, length, capitalize);
		}
	}
}