using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Cidade
    {
        [Required]
        public virtual int? Id { get; set; }
        [Required]
        public virtual string? Descricao { get; set; }
        [Required]
        public virtual string? UF { get; set; }
    }
}
