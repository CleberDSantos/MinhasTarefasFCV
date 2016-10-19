namespace MinhasTarefas.UI.Models
{
    using System.Collections.Generic;

    public class Categoria
    {

        public Categoria()
        {
            this.Tarefas = new List<Tarefa>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}