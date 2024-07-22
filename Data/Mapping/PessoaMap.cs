using Data.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class PessoaMap : ClassMap<Pessoa>
    {
        public PessoaMap()
        {
            Table("PESSOA");

            Id(x => x.Id)
                .Column("PES_ID")
                .GeneratedBy.Native("GEN_PES_ID")
                .Not.Nullable();

            Map(x => x.Nome)
                .Column("PES_NOME")
                .Not.Nullable();

            Map(x => x.CPF)
                .Column("PES_CPF")
                .Not.Nullable();

            Map(x => x.CEP)
                .Column("PES_CEP")
                .Not.Nullable();

            Map(x => x.Endereco)
                .Column("PES_ENDERECO")
                .Not.Nullable();

            Map(x => x.NumeroEndereco)
                .Column("PES_ENDERECO_NR")
                .Not.Nullable();

            Map(x => x.TelefonePrincipal)
                .Column("PES_TELEFONE_PRINCIPAL")
                .Not.Nullable(); 

            Map(x => x.TelefoneSecundario)
                .Column("PES_TELEFONE_SECUNDARIO")
                .Not.Nullable();
        }
    }
}
