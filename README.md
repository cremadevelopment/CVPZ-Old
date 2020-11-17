# CVPZ

## Getting Started

- Install [node js](https://nodejs.org/en/)
- Install [dotnet core sdk](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- Install [Entity Framework Core Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/)

## Entity Framework Migrations

<https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli>

### Creating a Migration

``` PS
dotnet ef migrations add InitialCreate --project .\src\CVPZ.Infrastructure\CVPZ.Infrastructure.csproj --startup-project .\src\CVPZ\CVPZ.csproj --verbose --context CVPZContext
```

## ToDo

- Modify `CVPZContextFactory` to use CVPZ connection string or the first argument as the connection string
- Should we identify environment of Develop, local, production and initialize/migrate the database there?
- Do we have to identify if it's sql lite or sql server before to not migrate if it's sql lite?

- Authorize maybe using this -> <https://dev.to/_patrickgod/basic-authentication-with-a-net-core-web-api-2a59>
    - Helpful links <https://jasonwatmore.com/post/2019/10/14/aspnet-core-3-simple-api-for-authentication-registration-and-user-management>
