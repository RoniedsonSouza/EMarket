using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IEmpresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Empresa.Commands
{
    public class EditEmpresa : IEditEmpresa
    {
        private readonly IEmpresaRepository empresaRepository;

        public EditEmpresa(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }
        public void Execute(CoreBusiness.Empresa empresa)
        {
            empresaRepository.UpdateEmpresa(empresa);
        }
    }
}
