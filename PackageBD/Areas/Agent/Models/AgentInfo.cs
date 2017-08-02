using PackageBD.DAL;
using PackageBD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PackageBD.Areas.Agent.Models
{
    public class AgentInfo
    {
        #region Agent infos
        /// <summary>
        /// Personal Details
        /// </summary>
        [Key, ForeignKey("AgentUser")]
        public string AgentInfoID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AgentCode { get; set; }
        public string AgencyName { get; set; }
        public string AgencyEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public IATAStatus IATAStatus { get; set; }
        public NatureOfBusiness NatureOfBusiness { get; set; }
        public BusinessType BusinessType { get; set; }
        public HearBy HearBy { get; set; }
        public PreferredCurrency PreferredCurrency { get; set; }
        //
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }

        // Foreign key 
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        // Foreign key 
        [Display(Name = "City")]
        public int CityID { get; set; }
        public City City_ag { get; set; }

        public TimeZoneEnum TimeZone { get; set; }
        public string Website { get; set; }

        [Display(Name = "Logo")]
        public string LogoPath { get; set; }

        /// <summary>
        /// Contact Details
        /// </summary>
        public string AccountsName { get; set; }
        public string AccountsEmail { get; set; }
        public string AccountsNumber { get; set; }

        public string ReservationName { get; set; }
        public string ReservationEmail { get; set; }
        public string ReservationNumber { get; set; }

        public string ManagementName { get; set; }
        public string ManagementEmail { get; set; }
        public string ManagementNumber { get; set; }

        public AccountActivation Activation { get; set; }
        public virtual ApplicationUser AgentUser { get; set; }
        #endregion
    }

    #region Enum
    //enum declaration 
    public enum IATAStatus
    {
        Approved = 1, NotApproved = 2,
    }
    public enum NatureOfBusiness
    {
        //[Display(Name = "Destination Management Company")]
        [Display(Name ="Destination Management Company")]
        DestinationManagementCompany = 1,
        [Display(Name = "Tour Operator")]
        TourOperator = 2,
        [Display(Name = "Travel Agent")]
        TravelAgent = 3,
        [Display(Name = "Whole Sale Travel Company")]
        WholeSaleTravelCompany = 4,
        [Display(Name = "Corporate")]
        Corporate = 5,
    }
    public enum BusinessType
    {
        B2B = 1, B2C = 2, Both = 3, Other = 4
    }
    public enum HearBy
    {
        [Display(Name ="E-mail Marketing")]
        a = 1,
        [Display(Name = "Trade Show")]
        b = 2,
        [Display(Name ="Search Engine")]
        c = 3,
        [Display(Name = "Advertisement")]
        d = 4,
        [Display(Name = "Business Associte Referral")]
        e = 5,
        [Display(Name = "Sales Person")]
        f = 6,
    }
    #endregion

}