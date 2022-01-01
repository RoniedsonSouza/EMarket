using System.Collections.Generic;

namespace Library.UseCaseInterfaces.IEmpresa
{
    public interface IViewEmpresa
    {
        IEnumerable<CoreBusiness.Empresa> Execute();
    }
}