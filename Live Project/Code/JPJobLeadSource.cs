using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobPlacementDashboard.Models
{
    public enum JPJobLeadSource
    {
        [Display(Name = "LinkedIn")]
        LinkeIn,
        [Display(Name = "Indeed")]
        Indeed,
        [Display(Name = "Career Builder")]
        CareerBuilder,
        [Display(Name = "Networking Event")]
        NetworkingEvent,
        [Display(Name = "Personal Connection")]
        PersonalConnection,
        [Display(Name = "Other")]
        Other
    }
}