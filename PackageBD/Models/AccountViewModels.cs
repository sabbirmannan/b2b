using PackageBD.Areas.Agent.Models;
using PackageBD.Areas.Supplier.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PackageBD.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class LoginViewModel_Agent
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Agent Code")]
        public long AgentCode { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        //[EmailAddress]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }


    public class RegisterViewModel_Agent
    {
        [Required]
        //[]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        #region agent info
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

        // Foreign key 
        [Display(Name = "City")]
        public int CityID { get; set; }
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

        #endregion
    }


    #region Supplier Registration
    public class RegisterViewModel_Supplier
    {
        [Required]
        //[]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        #region Supplier info
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
        
        // Foreign key 
        [Display(Name = "City")]
        public int CityID { get; set; }
      
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

        //accounts details
        public string AccountsName { get; set; }
        public string AccountsEmail { get; set; }
        public string AccountsNumber { get; set; }
        #endregion
    }
    #endregion


    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
