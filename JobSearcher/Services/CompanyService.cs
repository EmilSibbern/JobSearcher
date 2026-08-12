using JobSearcher.Data;
using JobSearcher.Models;
using Microsoft.EntityFrameworkCore;

namespace JobSearcher.Services;

public class CompanyService
{
    private readonly AppDbContext _context;

    public CompanyService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Company>> GetCompanies()
    {
        return await _context.Companies.ToListAsync();
    }
    
    public async Task AddCompany(Company company)
    {
        company.NormalizeDateKindsToUtc();
        _context.Companies.Add(company);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveCompany(Company company)
    {
        _context.Companies.Remove(company);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCompany(Company company)
    {
        company.NormalizeDateKindsToUtc();
        _context.Companies.Update(company);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAllCompanies()
    {
        _context.Companies.RemoveRange(_context.Companies);
        await _context.SaveChangesAsync();
    }
}