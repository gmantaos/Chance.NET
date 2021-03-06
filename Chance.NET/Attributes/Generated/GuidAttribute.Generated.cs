using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET.Attributes
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class GuidAttribute : ChanceAttribute
	{
		GuidVersion version = (GuidVersion)~0;


		public GuidAttribute(GuidVersion version = (GuidVersion)~0)
		{
			this.version = version;

		}

		internal override object GetValue(Chance chance)
		{
			return chance.Guid(version);
		}
	}
}
