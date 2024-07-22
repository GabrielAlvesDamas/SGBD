using Data.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class BairroMap : ClassMap<Bairro>
    {
        public BairroMap()
        {
            Table("BAIRRO");

            Id(x => x.Id)
                .Column("BAI_ID")
                .GeneratedBy.Native("GEN_BAI_ID")
                .Not.Nullable();

            Map(x => x.Descricao)
                .Column("BAI_DS")
                .Not.Nullable();
        }
    }
}
