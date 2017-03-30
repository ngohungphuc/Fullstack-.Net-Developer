using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
    }
}