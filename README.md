# Job Searcher

A Blazor Server application for tracking job applications and company contacts. It stores company details, application status, follow-up dates, notes, and contact information in a PostgreSQL database.

## Features

- Create, view, edit, and remove company entries
- Track application status, position, and applied date
- Save job links, websites, contacts, locations, and notes
- Track follow-up dates and whether a company should be called
- Persist data with Entity Framework Core and PostgreSQL

## Tech stack

- .NET 10
- Blazor Server with interactive server rendering
- Entity Framework Core
- PostgreSQL via Npgsql

## Getting started

The project requires the .NET 10 SDK and access to a PostgreSQL database.

1. Set the database connection string as the `ConnectionStrings__DefaultConnection` environment variable.

   ```powershell
   $env:ConnectionStrings__DefaultConnection = "Host=localhost;Database=jobsearcher;Username=postgres;Password=your-password"
   ```

2. Apply the included Entity Framework migrations:

   ```bash
   dotnet ef database update --project JobSearcher
   ```

3. Run the application:

   ```bash
   dotnet run --project JobSearcher
   ```

Open the local address printed in the terminal. The main pages are available at `/CreateCompany` and `/ShowAllCompanies`.

> This is a learning project and is not intended for production use.
