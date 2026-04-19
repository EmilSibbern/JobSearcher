using JobSearcher.Models.Enums;

namespace JobSearcher.Models;

public class Company
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public CompanyPosition CompanyPosition { get; set; }
    public string CompanyLocation { get; set; }
    public DateTime CompanyAppliedDate { get; set; }
    public CompanyStatus CompanyStatus { get; set; } = CompanyStatus.Interested;
    public string CompanyMinorNotes { get; set; }
    public string CompanyJobLink { get; set; }
    public string CompanyContactPerson { get; set; }
    public DateTime CompanyTopOfMind { get; set; }
    public string CompanyWebsite { get; set; }
    public CompanyCallOrNot CompanyCallOrNot { get; set; }
}