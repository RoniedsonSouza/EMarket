using Library.PluginInterfaces;
using Library.UseCaseInterfaces.IEmpresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Empresa.Queries
{
    public class GetEmpresaById : IGetEmpresaById
    {
        private readonly IEmpresaRepository empresaRepository;

        public GetEmpresaById(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }
        public CoreBusiness.Empresa Execute(int empresaId)
        {
            return empresaRepository.GetEmpresaById(empresaId);
        }
    }
}
