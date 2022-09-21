using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SWiFT_GNC_Scorecard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
           builder.Services.AddLogging();
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", a => a.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            });

            var dbPath = Path.Join(Directory.GetCurrentDirectory(), "OnyxDB.db");
            var conn = new SqliteConnection(@"Data Source={dbPath}");
            builder.Services.AddDbContext<OnyxDBContext>(o => o.UseSqlite(conn));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");
            app.UseAuthorization();

            app.MapGet("/parts", async (OnyxDBContext db) => await db.Parts.ToListAsync());
            app.MapGet("/parts/{id}", async (int id,OnyxDBContext db) => 
            await db.Parts.FindAsync(id) is Part part ? Results.Ok(part) : Results.NotFound()
            );

            app.MapPut("/parts/{id}", async (int id, Part part, OnyxDBContext db) =>
            {
                var record = await db.Parts.FindAsync(id);
                if (record is null) return Results.NotFound();

                part.DeptID = record.DeptID;
                part.UserID = record.UserID;
                part.Schedule = record.Schedule;
                part.OrderNumber = record.OrderNumber;
                part.WALLNUM = record.WALLNUM;
                part.ROOMNUM = record.ROOMNUM;
                part.LINNUM = record.LINNUM;
                part.PARTQTY = record.PARTQTY;
                part.WIDTH = record.WIDTH;
                part.WIDTHSTR = record.WIDTHSTR;
                part.LENGTH = record.LENGTH;
                part.LENGTHSTR = record.LENGTHSTR;
                part.DEPTH = record.DEPTH;
                part.DEPTHSTR = record.DEPTHSTR;
                part.PARTID = record.PARTID;
                part.PARTNAME = record.PARTNAME;
                part.MATERIALID = record.MATERIALID;
                part.MATERIALNAME = record.MATERIALNAME;

                await db.SaveChangesAsync();
                return Results.NoContent();
    });


            app.MapDelete("/parts/{id}", async (int id, OnyxDBContext db) =>
            {
                var record = await db.Parts.FindAsync(id);
                if (record is null) return Results.NotFound();
                db.Remove(record);

                await db.SaveChangesAsync();
                return Results.NoContent();
            });


            app.MapPost("/parts", async (int id,Part part, OnyxDBContext db) =>
            {
                await db.AddAsync(part);
                await db.SaveChangesAsync();
                return Results.Created($"/parts/{part.ID}", part);
            });
            app.Run();
        }
    }
}