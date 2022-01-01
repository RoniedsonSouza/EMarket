namespace Library.UseCaseInterfaces.IEmpresa
{
    public interface IGetEmpresaById
    {
        CoreBusiness.Empresa Execute(int empresaId);
    }
}