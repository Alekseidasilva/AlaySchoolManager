using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    //c.SwaggerDoc("", new OpenApiInfo
    //{
    //    Title = "ALAYSchoolManagerApi",
    //    Version = "v1",
    //    Contact = new OpenApiContact
    //    {
    //        Name = "A.J.M.D.S - Soluções Tecnologicas",
    //        Email = "geral@ajmdstec.ao",
    //        Url = new Uri("https://ajmdstec.ao")
    //    },

    //});
    //var xmlFile = "ALAYSchoolManagerApi.xml";
    //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    //c.IncludeXmlComments(xmlPath);
});

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
