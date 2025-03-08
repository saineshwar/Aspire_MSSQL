var builder = DistributedApplication.CreateBuilder(args);

var password = builder.AddParameter("password", secret: true);

var sql = builder.AddSqlServer("mssql", password)
    .WithLifetime(ContainerLifetime.Persistent);

var db = sql.AddDatabase("aspiredatabase");

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.AspireApp7_ApiService>("apiservice")
    .WithReference(db)
    .WaitFor(db);

builder.AddProject<Projects.AspireApp7_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
