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
         //   app.UseAuthorization();

            app.MapGet("/parts", async (OnyxDBContext db) => await db.Parts.ToListAsync());
            app.MapGet("/parts/{id}", async (int id,OnyxDBContext db) => 
            await db.Parts.FindAsync(id) is Part part ? Results.Ok(part) : Results.NotFound()
            );

            app.MapPut("/parts/{id}", async (int id, Part part, OnyxDBContext db) =>
            {
                var record = await db.Parts.FindAsync(id);
                if (record is null) return Results.NotFound();

                record.DeptID = part.DeptID;
                record.UserID = part.UserID;
                record.Schedule = part.Schedule;
                record.OrderNumber = part.OrderNumber;
                record.WALLNUM = part.WALLNUM;
                record.ROOMNUM = part.ROOMNUM;
                record.LINNUM = part.LINNUM;
                record.PARTQTY = part.PARTQTY;
                record.WIDTH = part.WIDTH;
                record.WIDTHSTR = part.WIDTHSTR;
                record.LENGTH = part.LENGTH;
                record.LENGTHSTR = part.LENGTHSTR;
                record.DEPTH = part.DEPTH;
                record.DEPTHSTR = part.DEPTHSTR;
                record.PARTID = part.PARTID;
                record.PARTNAME = part.PARTNAME;
                record.MATERIALID = part.MATERIALID;
                record.MATERIALNAME = part.MATERIALNAME;

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