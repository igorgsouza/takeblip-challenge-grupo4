using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blipetshop.Entities
{
	public record DailySchedule
	{
		public string Day { get; init; }
		public string Time1 { get; init; }
		public string Time2 { get; init; }
		public string Time3 { get; init; }
	}
}
