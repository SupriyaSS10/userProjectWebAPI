var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the   HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => {
builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();


//Mysql---->
// create database userinfo;
// use userinfo;
// create table users (userid integer primary key auto_increment, username varchar(50), course varchar(50), purchasedate date);
// insert into users values(10, "Supriya", "Java", "2020-01-01");
// insert into users(username, course, purchasedate) values("Shruti", "Python", "202-012-22");

// Terminal of webapi--->
//dotnet new sln
//dotnet add package mysql.data
//dotnet add package MicroSoft.ASPNetCore.Cores
//dotnet build
//dotnet run
//URL-->http://localhost:5110/swagger
