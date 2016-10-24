namespace MinhasTarefas.UI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;   

    public class Categoria
    {

        public Categoria()
        {
            this.Tarefas = new List<Tarefa>();
        }

        public int Id { get; set; }

        [Display(Name ="Digite seu nome:")]
        [Required(ErrorMessage ="Esse campo é obrigatório!")]
        public string Nome { get; set; }

        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}