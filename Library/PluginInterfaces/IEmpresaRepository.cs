using CoreBusiness;
using System.Collections.Generic;

namespace Library.PluginInterfaces
{
    public interface IEmpresaRepository
    {
        CoreBusiness.Empresa GetEmpresaById(int empresaId);
        void SalvarEmpresa(CoreBusiness.Empresa empresa);
        void UpdateEmpresa(CoreBusiness.Empresa empresa);
        IEnumerable<CoreBusiness.Empresa> GetEmpresas();
    }
}