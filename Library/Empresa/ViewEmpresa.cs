using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IEmpresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Empresa
{
    public class ViewEmpresa : IViewEmpresa
    {
        private readonly IEmpresaRepository empresaRepository;

        public ViewEmpresa(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }
        public IEnumerable<CoreBusiness.Empresa> Execute()
        {
            return empresaRepository.GetEmpresas();
        }
    }
}
