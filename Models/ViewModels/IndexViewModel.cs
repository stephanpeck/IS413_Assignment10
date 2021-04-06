using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//ViewModel combining multiple models that we need for out Index View
namespace DataFirst.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Bowlers> Bowlers { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string BowlingTeam { get; set; }
    }
}
