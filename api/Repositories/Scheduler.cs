using blipetshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blipetshop.Repositories
{
	public class Scheduler
	{

		private readonly List<DailySchedule> items = new()
		{
			new DailySchedule { Day = "segunda", Time1 = "14:00", Time2 = "17:00", Time3 = "19:00" },
			new DailySchedule { Day = "terça", Time1 = "11:00", Time2 = "21:00", Time3 = "13:00" },
			new DailySchedule { Day = "quarta", Time1 = "13:00", Time2 = "15:00", Time3 = "19:00" },
			new DailySchedule { Day = "quinta", Time1 = "09:00", Time2 = "11:00", Time3 = "16:00" },
			new DailySchedule { Day = "sexta", Time1 = "12:00", Time2 = "13:00", Time3 = "21:00" },
			new DailySchedule { Day = "sabado", Time1 = "14:00", Time2 = "16:00", Time3 = "19:00" },
			new DailySchedule { Day = "domingo", Time1 = "14:00", Time2 = "18:00", Time3 = "23:00" }
		};


		public DailySchedule GetSchedule(string day)
		{
			return items.Where(schedule => schedule.Day == day).SingleOrDefault();
		}

	}
}
