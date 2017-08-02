using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PackageBD.Areas.Supplier.Models
{
    public class FileDetail
    {
        [Key]
        public Guid FileDetailsId { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int TourPackageId { get; set; }
        public virtual TourPackage TourPackage { get; set; }
    }
}