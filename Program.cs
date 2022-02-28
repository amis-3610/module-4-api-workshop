using Api.Workshop;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// change the ports for HTTP and HTTPS
app.Urls.Add("http://localhost:5000");
app.Urls.Add("https://localhost:5001");

// add diagnostic information
app.Logger.LogInformation("Server is starting.");

// basic routing using anonymous / lambda functions
app.MapGet("/", () => "GET: Hello World!");
app.MapPost("/", () => "POST: Hello World!");
app.MapPut("/", () => "PUT: Hello World!");
app.MapDelete("/", () => "DELETE: Hello World!");

// use a function variable
var studentHandler = () => "this would return ALL students";
app.MapGet("/students", studentHandler);

// use a function from another file
app.MapGet("/courses", CoursesHandler.GetAllCourses);


app.Run();
