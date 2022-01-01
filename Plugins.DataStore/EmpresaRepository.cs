using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.PluginInterfaces;

namespace Plugins.DataStore
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly MarketContext context;

        public EmpresaRepository(MarketContext context)
        {
            this.context = context;
        }

        public void SalvarEmpresa(Empresa empresa)
        {
            context.Empresa.Add(empresa);
            context.SaveChanges();
        }

        public Empresa GetEmpresaById(int empresaId)
        {
            return context.Empresa.Find(empresaId);
        }

        public void UpdateEmpresa(Empresa empresa)
        {
            var emp = context.Empresa.Find(empresa.EmpresaId);
            emp.Nome = empresa.Nome;
            emp.CNPJ = empresa.CNPJ;
            emp.Telefone = empresa.Telefone;
            emp.Celular = empresa.Celular;
            emp.Endereco = empresa.Endereco;
            emp.Cidade = empresa.Cidade;
            emp.Estado = empresa.Estado;
            emp.Pais = empresa.Pais;
            emp.Sobre = empresa.Sobre;

            context.SaveChanges();
        }
        public IEnumerable<Empresa> GetEmpresas()
        {
            return context.Empresa.ToList();
        }
    }
}
