using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgresQuerysWithC_.Entities;

[Table("humans")]
public class Humans
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    [Column("age")]
    public int Age { get; set; }
    [Column("password")]
    public string Password { get; set; }
    [Column("ismarried")]
    public bool IsMarried { get; set; }
}
