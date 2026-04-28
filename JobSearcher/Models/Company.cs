using JobSearcher.Models.Enums;

namespace JobSearcher.Models;

public class Company
{
    public Company() {}

    public int Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public CompanyPosition CompanyPosition { get; set; }
    public string CompanyLocation { get; set; } = string.Empty;
    public DateTime CompanyAppliedDate { get; set; } = DateTime.UtcNow;
    public CompanyStatus CompanyStatus { get; set; } = CompanyStatus.Interested;
    public string CompanyMinorNotes { get; set; } = string.Empty;
    public string CompanyJobLink { get; set; } = string.Empty;
    public string CompanyContactPerson { get; set; } = string.Empty;
    public DateTime CompanyTopOfMind { get; set; } = DateTime.UtcNow;
    public string CompanyWebsite { get; set; } = string.Empty;
    public CompanyCallOrNot CompanyCallOrNot { get; set; }

    public Company(Company other)
    {
        Id = other.Id;
        CompanyName = other.CompanyName;
        CompanyPosition = other.CompanyPosition;
        CompanyLocation = other.CompanyLocation;
        CompanyStatus = other.CompanyStatus;
        CompanyMinorNotes = other.CompanyMinorNotes;
        CompanyJobLink = other.CompanyJobLink;
        CompanyContactPerson = other.CompanyContactPerson;
        CompanyWebsite = other.CompanyWebsite;
        CompanyCallOrNot = other.CompanyCallOrNot;
    }
}