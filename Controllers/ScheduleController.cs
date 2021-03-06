﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace capstone.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Schedule> Get()
        {
            Schedule[] schedules = null;
            using (var context = new ApplicationDbContext())
            {
                schedules = context.Schedules.ToArray();
            }
            return schedules;

        }

        [HttpPost]
        public Schedule Post([FromBody]Schedule schedule)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            return schedule;
        }

    }
}