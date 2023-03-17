using CommanderDB.Mutation;
using CommanderDB.QueryData;
using Data.AppCommandDbContext;
using Microsoft.EntityFrameworkCore;
using QueryData.Query;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPooledDbContextFactory<AppCommandDbContext>(opt => opt.UseSqlServer
(builder.Configuration.GetConnectionString("Connection")));

builder.Services
.AddGraphQLServer()
.AddQueryType<Query>()
.AddProjections()
.AddFiltering()
.AddMutationType<Mutations>()
.AddSorting()
.AddSubscriptionType<Subscriptions>()
.AddInMemorySubscriptions()
.RegisterDbContext<AppCommandDbContext>(DbContextKind.Pooled);

var app = builder.Build();

app.UseWebSockets();
app.MapGraphQL();
app.UseGraphQLVoyager();


app.Run();
