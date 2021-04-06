using DataFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFirst.Components
{
    public class TeamViewComponent : ViewComponent
    {

        private BowlingLeagueContext context;
        public TeamViewComponent (BowlingLeagueContext ctx)
        {
            context = ctx;
        }



        //what do you want me to do when called?
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["teamname"];

            return View(context.Teams
                //.Select(x => x.TeamName)
                .Distinct()
                .OrderBy(x => x)
                .ToList()
                );
        }
    }
}
