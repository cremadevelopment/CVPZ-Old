docker volume create cvpz-data

docker run `
    -e 'ACCEPT_EULA=Y' `
    -e 'SA_PASSWORD=yourStrong(!)Password' `
    -p 8433:1433 `
    -v cvpz-data:/var/opt/mssql `
    -d --name cvpz_sql_server `
    microsoft/mssql-server-linux:2017-GA
