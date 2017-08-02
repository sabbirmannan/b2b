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
        public string Highlights { get; set; }
        public string InclusionExclusion { get; set; }
        public string TourDestination { get; set; }
        public string SpecialNotes { get; set; }

        //pricing area
        public decimal TourCostPrice { get; set; }
        public decimal TourSalesPrice { get; set; }
        public decimal TourDiscountPrice { get; set; }
        //
        //enum dd area
        public TotalNights TotalNights { get; set; }
        public HotelStar HotelStar { get; set; }
        //
        public string HotelInUse { get; set; }

        public string DayWiseItienary { get; set; }
        public string TearmsAndConditions { get; set; }
        public string Allotment { get; set; }
        public int Adults { get; set; }
        public int Childrens { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime DepartingDate { get; set; }
        public DateTime ValidityDate { get; set; }

        #region DayWiseItinary
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
        #endregion

        public virtual SupplierInfo SupplierInfo { get; set; }

        public virtual ICollection<FileDetail> FileDetails { get; set; }
        public virtual ICollection<BookPackage> BookPackages { get; set; }
    }

    public class TourPackageDetails
    {
        public TourPackageDetails()
        {
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

        public int TourPackageID { get; set; }
        public virtual TourPackage TourPackage { get; set; }
    }



    #region enum
    public enum HotelStar
    {
        [Display(Name = "3 Star")]
        a = 0,
        [Display(Name = "4 Star")]
        b = 1,
        [Display(Name = "5 Star")]
        c = 2
    }

    public enum TotalNights
    {
        [Display(Name = "2 Nights 3 Days")]
        a = 2,
        [Display(Name = "3 Nights 4 Days")]
        b = 3,
        [Display(Name = "4 Nights 5 Days")]
        c = 4,
        [Display(Name = "5 Nights 6 Days")]
        d = 5,
        [Display(Name = "6 Nights 7 Days")]
        e = 6,
        [Display(Name = "7 Nights 8 Days")]
        f = 7,
        [Display(Name = "8 Nights 9 Days")]
        g = 8,
        [Display(Name = "9 Nights 10 Days")]
        h = 9,
        [Display(Name = "10 Nights 11 Days")]
        i = 10
    }
    #endregion

}




