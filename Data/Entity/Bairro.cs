using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Bairro
    {
        [Required]
        public virtual int? Id { get; set; }
        [Required]
        public virtual string? Descricao { get; set; }
    }
}
