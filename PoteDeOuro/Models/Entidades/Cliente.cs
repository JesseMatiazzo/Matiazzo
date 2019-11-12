using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoteDeOuro.Models.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="Campo obrigatório")]
        [StringLength(30,ErrorMessage ="Nome inválido")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(8, ErrorMessage ="O campo deve ter no minimo 8 digitos")]

        public int Cep { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Phone]
        [Display(Name = "Telefone Fixo")]
        public int TelefoneFixo { get; set; }

        [Phone]
        public int Celular { get; set; }

        [EmailAddress(ErrorMessage ="E-mail inválido")]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [Range(6,10,ErrorMessage ="O usuario deve ter no minimo {0} e no máximo {1} caracteres")]
        [Display(Name ="Usuário")]
        public string Usuario { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [Range(4,10,ErrorMessage ="A senha deve ter no minimo {0} e no máximo {1} caracteres")]
        public string Senha { get; set; }
        
        [Required(ErrorMessage ="Campo obrigatório")]
        [Compare("Senha",ErrorMessage ="Senhas diferentes")]
        public string ConfirmarSenha { get; set; }

        public Endereco Endereco { get; set; }

        public Cliente()
        {
        }

        public Cliente(int clienteId, string nome, int cep, DateTime dataNascimento, int telefoneFixo, int celular, string email, string usuario, string senha, string confirmarSenha, Endereco endereco)
        {
            ClienteId = clienteId;
            Nome = nome;
            Cep = cep;
            DataNascimento = dataNascimento;
            TelefoneFixo = telefoneFixo;
            Celular = celular;
            Email = email;
            Usuario = usuario;
            Senha = senha;
            ConfirmarSenha = confirmarSenha;
            Endereco = endereco;
        }
    }
}
