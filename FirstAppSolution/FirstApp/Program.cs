using FirstApp.Models;

Console.WriteLine("Starting up the API");
var builder = WebApplication.CreateBuilder(args);
// Configuration for the API will go here.


Console.WriteLine("About to start the API");
// When ready to start things up, need to tell it how to match incoming requests to things in the application.
var app = builder.Build();
// GET /sayhi

app.MapGet("/sayhi", () => Results.Ok("Yep! Hello, good to see you"));


app.MapGet("/status", () =>{
    var response = new StatusResponseModel(DateTime.Now, "Looks Good", "Operating Normally"); // Want to convert the var response to JSON bc you cant send a .NET object across a network.
    return Results.Ok(response); // Whatever you put in the Ok will be autoconverted to JSON
});

app.MapGet("/todo-list", () =>
{
    var response = new List<TodoItemModel>()
    {
        new TodoItemModel(Guid.NewGuid(), "Buy Beer", "Later"),
        new TodoItemModel(Guid.NewGuid(), "Mow Lawn", "Waiting"),
    };
    return Results.Ok(response);
});


// Need a web server so that it will compile the application and make it continue running. Needs to keep listening for HTTP requests.

app.Run(); // Blocking call - this will start server and run FOREVER (or until we kill it)
Console.WriteLine("API is going down") ;
