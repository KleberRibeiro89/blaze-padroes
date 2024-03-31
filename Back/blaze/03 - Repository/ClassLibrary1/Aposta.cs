using System.ComponentModel.DataAnnotations.Schema;

namespace Blaze.Repository;

[Table("aposta")]
public class Aposta
{
    [Column("id")]
    public Guid Id { get; set; }

    [Column("blazeid")]
    public string BlazeId { get; set; }

    [Column("dataaposta")]
    public DateTime DataAposta { get; set; }

    [Column("cor")]
    public string Cor { get; set; }

    [Column("numero")]
    public int Numero { get; set; }
}
