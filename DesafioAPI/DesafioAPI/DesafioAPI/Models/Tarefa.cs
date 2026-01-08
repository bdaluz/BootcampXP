using System.ComponentModel.DataAnnotations;

namespace DesafioAPI.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; private set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; } = DateTime.Now.AddDays(3);
        public EnumStatusTarefa Status { get; set; } = EnumStatusTarefa.Pendente;

        public Tarefa(){}

        public Tarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
        }

        public Tarefa(string titulo, string descricao, DateTime data)
        {
            Titulo = titulo;
            Descricao = descricao;
            Data = data;
        }
    }
}