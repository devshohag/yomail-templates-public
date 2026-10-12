using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { message = "Your ASP.NET Core app is running." }));

app.MapGet("/health/database", async (IConfiguration configuration, CancellationToken cancellationToken) =>
{
    var connectionString = configuration.GetConnectionString("Default");
    if (string.IsNullOrWhiteSpace(connectionString))
        return Results.Problem("SQL Server connection is not configured.", statusCode: StatusCodes.Status503ServiceUnavailable);

    await using var connection = new SqlConnection(connectionString);
    await connection.OpenAsync(cancellationToken);
    await using var command = new SqlCommand("SELECT 1", connection);
    var result = await command.ExecuteScalarAsync(cancellationToken);
    return Results.Ok(new { database = Convert.ToInt32(result) == 1 ? "ok" : "error" });
});

app.Run();
