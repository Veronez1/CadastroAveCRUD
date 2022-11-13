using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroAve.Models
{
    [Table("Ave")]
    public class Ave
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("NomeComum")]
        [Display(Name = "Nome Comum")]
        public string NomeComum { get; set; }

        [Column("NomeCientifico")]
        [Display(Name = "Nome Científico")]
        public string NomeCientifico { get; set; }

        [Column("Reino")]
        [Display(Name = "Reino")]
        public string Reino { get; set; }

        [Column("Filo")]
        [Display(Name = "Filo")]
        public string Filo { get; set; }

        [Column("Classe")]
        [Display(Name = "Classe")]
        public string Classe { get; set; }

        [Column("Ordem")]
        [Display(Name = "Ordem")]
        public string Ordem { get; set; }

        [Column("Familia")]
        [Display(Name = "Família")]
        public string Familia { get; set; }

        [Column("Genero")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Column("Especie")]
        [Display(Name = "Espécie")]
        public string Especie { get; set; }

        [Column("DistribuicaoGeografica")]
        [Display(Name = "Distribuição Geográfica")]
        public string DistribuicaoGeografica { get; set; }

    }
}
