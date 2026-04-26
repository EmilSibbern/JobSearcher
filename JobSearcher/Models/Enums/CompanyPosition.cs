using System.ComponentModel.DataAnnotations;

namespace JobSearcher.Models.Enums;

public enum CompanyPosition
{
    [Display(Name = "It support")]
    ItSupport,
    [Display(Name = "Infrastructure")]
    Infrastructure,
    [Display(Name = "Programming")]
    Programming,
    [Display(Name = "Cyber Security")]
    CyberSecurity
}