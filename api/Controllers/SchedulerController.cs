using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blipetshop.Entities;
using blipetshop.Repositories;



namespace blipetshop.Controllers
{

	[ApiController]
	[Route("[controller]")]
	public class SchedulerController : ControllerBase
	{

		private readonly Scheduler repository;

		public SchedulerController()
		{
			repository = new Scheduler();
		}

		[HttpGet("{day}")]
		public ActionResult<DailySchedule> GetItem(string day)
		{
			var item = repository.GetSchedule(day);

			if (item is null)
			{
				return NotFound();
			}
			return item;
		}

	}
}
