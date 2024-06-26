using _1.API.Mapper;
using _2._Domain;
using _3._Data;
using _1.API.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//dependecy inyection
builder.Services.AddScoped<ITutorialData, TutorialOracleData>();
builder.Services.AddScoped<ITutorialDomain, TutorialDomain>();

builder.Services.AddScoped<IClientDomain, ClientDomain>();
builder.Services.AddScoped<IClientData, ClientMySqlData>();

builder.Services.AddScoped<IShoesData, ShoesMySqlData>();
builder.Services.AddScoped<IShoesDomain, ShoesDomain>();


builder.Services.AddAutoMapper(typeof(RequestToModel),typeof(ModelToRequest));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();