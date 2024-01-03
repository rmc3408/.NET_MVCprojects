# DOTNET command

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