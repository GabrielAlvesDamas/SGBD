using Data.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Pessoa
    {
        [Required]
        public virtual int? Id { get; set; }
        [Required]
        public virtual string? Nome { get; set; }
        [Required]
        public virtual string? CPF { get; set; }
        [Required]
        public virtual string? Endereco { get; set; }
        [Required]
        public virtual string? NumeroEndereco { get; set; }
        [Required]
        public virtual string? CEP { get; set; }
        [Required]
        public virtual string? TelefonePrincipal { get; set; }
        [Required]
        public virtual string? TelefoneSecundario { get; set; }
    }
}
