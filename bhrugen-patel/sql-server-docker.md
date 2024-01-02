## PULL SQL Server Docker image
`
docker pull mcr.microsoft.com/mssql/server
`

## RUN Container

`
docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=Secret@123' -v sqlserver:/var/opt/mssql -p 1433:1433 -d --name sql_server mcr.microsoft.com/mssql/server
`

## Go on Tools -> Connect to Server

serverName: localhost
Authentification: SQL server
username: SA
passowrd: Secret@123
check for: (1) encryted true, (2) Trust Server Certificate True and (3) save my password.
databaseName: tempdb


------------------------------

# Run Database

Update database
`cupdate-databasec`

create migration
` add-migration addCat `

