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
- The app lives in `localhost:5001`.

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
Use this postman collection to test the API.

## Acknowledgements
- This article by [@agavatar on Medium.](https://medium.com/@agavatar/webapi-with-net-core-and-postgres-in-visual-studio-code-8b3587d12823)

## Author
Sylvance Kerandi
