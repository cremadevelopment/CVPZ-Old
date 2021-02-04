# CVPZ

## Getting Started

- Install [node js](https://nodejs.org/en/)
- Install [dotnet core sdk](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- Install [Entity Framework Core Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/)

## Entity Framework Migrations

### Creating a Migration

``` PS
dotnet ef migrations add InitialCreate --project .\src\CVPZ.Infrastructure\CVPZ.Infrastructure.csproj --startup-project .\src\CVPZ\CVPZ.csproj --verbose --context CVPZContext
```

## ToDo

- Modify `CVPZContextFactory` to use CVPZ connection string or the first argument as the connection string
- Should we identify environment of Develop, local, production and initialize/migrate the database there?
- Do we have to identify if it's sql lite or sql server before to not migrate if it's sql lite?

- Authorize maybe useing this -> <https://dev.to/_patrickgod/basic-authentication-with-a-net-core-web-api-2a59>
  - Helpful links <https://jasonwatmore.com/post/2019/10/14/aspnet-core-3-simple-api-for-authentication-registration-and-user-management>

## Dependencies

- [MediatR]("https://github.com/jbogard/MediatR")
- [Scrutor]("https://github.com/khellang/Scrutor")
- [Serilog]("https://serilog.net/")
- [Swashbuckle]("https://github.com/domaindrivendev/Swashbuckle.AspNetCore")
- [Tactical.DDD]("https://github.com/aneshas/tactical-ddd")
