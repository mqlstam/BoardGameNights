using System;
using System.ComponentModel.DataAnnotations;

namespace BoardgameNight.Web.Models
{
    public class BoardgameNightViewModel
    {
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string HostFirstName { get; set; }
        public string HostLastName { get; set; }
        public string HostEmail { get; set; }
    }
}