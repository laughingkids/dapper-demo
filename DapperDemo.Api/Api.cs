using DataAccess.Models;
using DataAccess.Repository;

namespace DapperDemo;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet("/users", GetUsers);
        app.MapGet("/users/{id}", GetUser);
        app.MapPost("/users", InsertUser);
        app.MapPut("/users", UpdateUser);
        app.MapDelete("/users/{id}", DeleteUser);
    }
    
    private static async Task<IResult> GetUsers(IUserRepository repository)
    {
        try
        {
            return Results.Ok(await repository.GetUsers());
        } 
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    
    private static async Task<IResult> GetUser(Guid id, IUserRepository repository)
    {
        try
        {
            var user = await repository.GetUserById(id);
            if (user == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(user);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    
    private static async Task<IResult> InsertUser(UserModel user, IUserRepository repository)
    {
        try
        {
            await repository.InsertUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    
    private static async Task<IResult> UpdateUser(UserModel user, IUserRepository repository)
    {
        try
        {
            await repository.UpdateUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    
    private static async Task<IResult> DeleteUser(Guid id, IUserRepository repository)
    {
        try
        {
            await repository.DeleteUser(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}