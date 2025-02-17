
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaEstiloWeb.Models;
[Table]
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public bool ExibirHome { get; set; } = false;
    }
