using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFirst.Models.ViewModels
{
    public class PageNumberingInfo
    {
        public int NumItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumItems { get; set; }

        //since the items per page might not end up dividing exactly even, you will want to round up your pages. (You can't have 5.3 pages, you would need 6)
        //Math.Ceiling rounds up the decimal value to a whole number, and (int) casts to integer
        public int NumPages => (int) Math.Ceiling((decimal) TotalNumItems / NumItemsPerPage);
    }
}
