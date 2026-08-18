FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY JobSearcher/JobSearcher.csproj JobSearcher/
RUN dotnet restore JobSearcher/JobSearcher.csproj

COPY . .
RUN dotnet publish JobSearcher/JobSearcher.csproj \
    --configuration Release \
    --output /app/publish \
    --no-restore \
    /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

COPY --from=build /app/publish .

USER $APP_UID
ENTRYPOINT ["dotnet", "JobSearcher.dll"]
