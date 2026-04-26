using System.ComponentModel.DataAnnotations;

namespace JobSearcher.Models.Enums;

public enum CompanyStatus
{
    [Display(Name = "Interested")] Interested,
    [Display(Name = "Denied")] Denied,
    [Display(Name = "Interview")] Interview,
    [Display(Name = "Second interview")] SecondInterview,
    [Display(Name = "Position Offered")] Offer,
    [Display(Name = "No response")] NoResponse
}