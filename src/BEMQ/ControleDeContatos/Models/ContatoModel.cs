using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório ")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O numero de Matrícula é obrigatório ")]
         public string Matricula { get; set; }
            [Required(ErrorMessage = "O horario de Entrada é obrigatório ")]
        public DateTime Entrada { get; set; }
        [Required(ErrorMessage = "O horario de Saída é obrigatório ")]
        public DateTime Saida { get; set; }
        public int? UsuarioId { get; set; }

        public UsuarioModel Usuario { get; set; }
    }
}