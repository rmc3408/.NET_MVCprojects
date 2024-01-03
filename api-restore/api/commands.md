# DOTNET command

To get a list of templates:
`dotnet new list`

solution:
` dotnet new sln`

Project:
` dotnet new webapi --use-controllers -o api`

connect project to solution:
`dotnet sln add api`

add Certificate for HTTPS:
`dotnet dev-certs https --trust`


Enter in project folder api and RUN:
`dotnet run --launch-profile http`

Hot Reload for development
` dotnet watch run --launch-profile http`

Install tools - package manager tools - dotnet ef
`dotnet tool install --global dotnet-ef`

` dotnet ef migrations add InitialCreate


	- Migration on Powershell:
`
dotnet ef migrations add first -o Database/Migrations
dotnet ef database update
`

- Migration on Package Manager Console:
`
Add-Migration first
Update-Database
`