// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using PostgresQuerysWithC_.Context;
using PostgresQuerysWithC_.Entities;
using System.Reflection.Emit;

var db = new AppDbContext();

var ismlar = await db.humans.FromSqlRaw("SELECT name FROM humans;").ToListAsync();

var users = await db.humans.FromSqlRaw("SELECT * FROM humans ORDER BY name;").ToListAsync();

var sonlar = await db.humans.Select(x => x.Name).OrderByDescending(p=>p.StartsWith('a')).ToListAsync();

var names = await db.humans
    .Where(u => u.Age > 20 || u.Name == "elbek")
    .OrderBy(u => u.Age)
    .Take(4)
    .Select(u => new { u.Id, u.Name })
    .ToListAsync();

foreach (var item in ismlar)
{
    Console.WriteLine(item);
}


