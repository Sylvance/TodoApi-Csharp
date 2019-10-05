# Todo API
Todo Restful API with postgres database.

## Installation
- Clone this repo `git clone https://github.com/Sylvance/TodoApi-Csharp`
- Change location in your terminal into this repo and get dependencies `cd TodoApi-Csharp && dotnet restore`
- Setup the postgresql database:
    - Edit the `ConnectionStrings` in `appsettings.json` by changing the values of `Host`, `Port`, `Username`, `Password` and `Database` accordingly.
    - Update the database using `dotnet ef database update`. This will use the current migration.

## Running the application
- Spin up the application using `dotnet run`
- The app UI lives in `localhost:5001`.

## Adding migrations
- If the postgresql database is setup:
    - Add migrations using `dotnet ef migrations add [migration-name]`.
    - Update the database using `dotnet ef database update`.

## Routes
| Method      | Route            | Action              |
| ---         |    ---           |                 --- |
| GET todos   | `/api/todo`      | list all todo items |
| GET todo    | `/api/todo/{id}` | show one todo item  |
| POST todo   | `/api/todo`      | create a todo item  |
| PUT todo    | `/api/todo/{id}` | update a todo item  |
| DELETE todo | `/api/todo/{id}` | delete a todo item  |

## Postman collection
Use this postman collection to test the API. You will have to turn off SSL certificate verification in Postman settings.

[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/d0ccf2c7759a9449a000)

## Acknowledgements
- This article by [@agavatar on Medium.](https://medium.com/@agavatar/webapi-with-net-core-and-postgres-in-visual-studio-code-8b3587d12823)
- This article by [@kieran on Medium](https://medium.com/@kieran.gillibrand/creating-a-net-core-rest-api-part-1-setup-and-database-modelling-47bccf8d5685) is more in-depth.
- [Bonus article.](https://intellitect.com/docker-postgresql/)
- [Front-end article for Todo API.](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-javascript?view=aspnetcore-3.0)

## Author
Sylvance Kerandi
