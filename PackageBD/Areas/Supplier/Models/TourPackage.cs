using PackageBD.Areas.Agent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PackageBD.Areas.Supplier.Models
{
    public class TourPackage
    {
        public TourPackage()
        {
            this.FileDetails = new HashSet<FileDetail>();
            this.BookPackages = new HashSet<BookPackage>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TourPackageID { get; set; }
        public string TourPackageTitle { get; set; }
        public decimal TourPrice { get; set; }
        public decimal TourDiscountPrice { get; set; }

        public int TotalNights { get; set; }

        public string Itinerary { get; set; }
        public string Facilities { get; set; }
        public string TearmsAndConditions { get; set; }
        public string FAQ { get; set; }
        public string Available { get; set; }
        public string HotelName { get; set; }
        public string TourDestination { get; set; }

        public string HotelStar { get; set; }
        public int Adults { get; set; }
        public int Childrens { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime DepartingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        
        public string SuplierInfoId { get; set; }
        public virtual SupplierInfo SupplierInfo { get; set; }

        public virtual ICollection<FileDetail> FileDetails { get; set; }
        public virtual ICollection<BookPackage> BookPackages { get; set; }
    }

    public class TourPackageDetails
    {
        public TourPackageDetails()
        {
            this.FileDetails = new HashSet<FileDetail>();
            this.BookPackages = new HashSet<BookPackage>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TourPackageDetailsID { get; set; }
        public string Description { get; set; }
        public string DayOne { get; set; }
        public string DayTwo { get; set; }
        public string DayThree { get; set; }
        public string DayFour { get; set; }
        public string DayFive { get; set; }
        public string DaySix { get; set; }
        public string DaySeven { get; set; }
        public string DayEight { get; set; }
        public string DayNine { get; set; }
        public string DayTen { get; set; }
        
        public virtual ICollection<FileDetail> FileDetails { get; set; }
        public virtual ICollection<BookPackage> BookPackages { get; set; }
    }


}




