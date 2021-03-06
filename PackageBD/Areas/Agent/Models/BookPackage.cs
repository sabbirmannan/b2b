﻿using PackageBD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PackageBD.Areas.Agent.Models
{
    public class BookPackage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        //
        public string ContactDetails { get; set; }
        public string ReservationDetails { get; set; }
        //
        public string Message { get; set; }
        public string City { get; set; }
        public virtual Country Country { get; set; }

        //
        public DateTime DepartingDate { get; set; }
        public TourType TourType { get; set; }
        //

        public virtual AgentInfo AgentInfo { get; set; }
    }

    //enum
    public enum TourType
    {
        [Display(Name = "Regular Tour")]
        a = 0,
        [Display(Name = "Private Tour")]
        b = 1,
    }
}