using Data.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class CidadeMap : ClassMap<Cidade>
    {
        public CidadeMap()
        {
            Table("CIDADE");

            Id(x => x.Id)
                .Column("CID_ID")
                .GeneratedBy.Native("GEN_CID_ID")
                .Not.Nullable();

            Map(x => x.Descricao)
                .Column("CID_DS")
                .Not.Nullable();

            Map(x => x.UF)
                .Column("CID_UF")
                .Not.Nullable();
        }
    }
}

