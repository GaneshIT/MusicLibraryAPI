using Microsoft.EntityFrameworkCore;
using MusicLibraryBusiness.Services;
using MusicLibraryData;
using MusicLibraryData.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Configuration ->Appsetting.json
builder.Services.AddControllers();
//To get connection string from appsetting.json file
var connection = builder.Configuration.
                GetConnectionString("SqlConnection");
//To establish database connection using Dbcontext
builder.Services.AddDbContext<MusicLibraryContext>
    (options =>options.UseSqlServer(connection));
//IAlbumRepository albumRepo=new AlbumRepository();
builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();
builder.Services.AddScoped<IAlbumService, AlbumService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
