using System.ComponentModel.DataAnnotations;

namespace JobSearcher.Models.Enums;

public enum CompanyCallOrNot
{
    [Display(Name = "Should call")]
    ShouldCall,
    [Display(Name = "Should not call")]
    ShouldNotCall
}