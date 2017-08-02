using PackageBD.DAL;
using PackageBD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PackageBD.Areas.Supplier.Models
{
    #region Supplier Entities
    public class SupplierInfo
    {
        //
        #region Supplier Details
            /// <summary>
            /// Supplier Details
            /// </summary>
        [Key, ForeignKey("SupplierUser")]
        public string SupplierID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplerAddress { get; set; }

        [Display(Name = "Pincode/Zipcode/Postcode")]
        public string Postcode { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string SupEmail { get; set; }

        // Foreign key 
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        // Foreign key 
        [Display(Name = "City")]
        public int CityID { get; set; }
        public City City_sp { get; set; }

        public TimeZoneEnum TimeZone { get; set; }
        public PreferredCurrency PreferredCurrency { get; set; }
        public ServiceTypeEnum SrviceType { get; set; }
        #endregion

        #region Contact Details
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactEmail { get; set; }

        public string ContactPerson1 { get; set; }
        public string ContactPerson2 { get; set; }
        //email
        public string ReservationEmail { get; set; }
        public string CancellationEmail { get; set; }
        public string ModificationEmail { get; set; }
        public string TechnicalEmail { get; set; }
        //email

        // account details
        public string AccountsName { get; set; }
        public string AccountsEmail { get; set; }
        public string AccountsNumber { get; set; }

        public AccountActivation Activation { get; set; }
        #endregion

        public virtual ApplicationUser SupplierUser { get; set; }   
    }
    #endregion

    #region Enum
    public enum ServiceTypeEnum
    {
        [Display(Name = "Tour Package")]
        a = 1,
        [Display(Name = "Hotel")]
        b = 2,
        [Display(Name = "Transfer")]
        c = 3
    }
    #endregion
}