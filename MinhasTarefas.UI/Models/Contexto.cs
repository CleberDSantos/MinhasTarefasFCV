using System.Data.Entity;

namespace MinhasTarefas.UI.Models
{
    public class Contexto : DbContext
    {

        public Contexto()
            : base("Conexao")
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}