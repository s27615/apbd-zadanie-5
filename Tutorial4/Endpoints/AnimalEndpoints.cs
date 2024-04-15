using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            // 200 - Ok
            // 201 - Created
            // 400 - Bad request
            // 401 - Unauthorized
            // 403 - Forbidden
            // 404 - Not Found
            var animals = MockDb.Animals;
    
            return Results.Ok(animals);
        });

        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(id);
        });

        app.MapPost("/animals/new", (Animal animal) =>
        {
            return Results.Created("", animal);
        });
        app.MapPost("/animals/edit", (int it, string name, string category, double weight, string color) =>
        {
            return Results.Created("", null);
        });
        app.MapGet("/animals/delete", (int id) =>
        {
            return Results.Ok(id);
        });
        app.MapPost("/Visits/new", (Visit visit) =>
        {
            return Results.Created("", visit);
        });
        app.MapPost("/Visits/show", (int idAnimal) =>
        {
            var visits = MockDb.Visits;
            return Results.Created("", visits);
        });
    }

}