var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<BookDbContext>();
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
