namespace MinhasTarefas.UI.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public int CategoriaId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}