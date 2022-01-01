using CoreBusiness;
using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IEmpresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Empresa.Commands
{
    public class AddEmpresa : IAddEmpresa
    {
        private readonly IEmpresaRepository empresaRepository;
        public AddEmpresa(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }
        public void Execute(CoreBusiness.Empresa empresa)
        {
            empresaRepository.SalvarEmpresa(empresa);
        }
    }
}
