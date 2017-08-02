using PackageBD.Areas.Supplier.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PackageBD.Models
{
    public class PackageViewModel
    {
        public TourPackage TourPackage { get; set; }
        public IEnumerable<TourPackage> Pakcage_IE { get; set; }
        public ICollection<FileDetail> Files_IC { get; set; }
    }

    public class TourPackageSearchModel
    {
        public int? Page { get; set; }

        [Display(Name = "Destination")]
        public string Destination { get; set; }
        public decimal? Price { get; set; }
        public int? Nights { get; set; }
        public IPagedList<TourPackage> SearchResults { get; set; }
        public string SearchButton { get; set; }
    }

    public class TourPackageViewDetailsVM
    {
        public virtual TourPackage TourPackage { get; set; }
        public virtual List<FileDetail> FileDetail { get; set; }
    }
}
