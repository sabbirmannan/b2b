using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PackageBD.Models
{
    public class EnumCommon
    {
    }

    public enum PreferredCurrency
    {
        [Display(Name = "BDT")]
        a = 1,
        [Display(Name = "USD")]
        b = 2,
        [Display(Name = "EURO")]
        c = 3
    }

    public enum TimeZoneEnum
    {
        [Display(Name = "(GMT+06:00) Dhaka")]
        a = 1,
        [Display(Name = "(GMT+06:00) Almaty")]
        b = 2,
        [Display(Name = "(GMT+05:30) Kolkata")]
        c = 3
    }

    public enum AccountActivation
    {
        InActive = 1, Active = 2, Deny = 3, Suspended=4
    }

}