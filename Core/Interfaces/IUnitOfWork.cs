using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICargoRepository Cargos { get; }
        IClienteRepository Clientes { get; }
        IDepartamentoRepository Departamentos { get; }
        IDetalleOrdenRepository DetalleOrdenes { get; }
        IDetalleVentaRepository DetalleVentas { get; }
        IEmpleadoRepository Empleados { get; }
        IEmpresaRepository Empresas { get; }
        IEstadoRepository Estados  { get; }
        IFormaPagoRepository FormaPagos { get; }
        IGeneroRepository Generos { get; }
        IInsumoPrendaRepository InsumoPrendas { get; }
        IInsumoRepository Insumos { get; }
        IInventarioRepository Inventarios { get; }
        IIsumoProveedorRepository InsumoProveedores { get; }
        IMunicipioRepository Municipios { get; }
        IOrdenRepository Ordenes { get; }
        IPaisRepository Paises { get; }
        IPrendaRepository Prendas { get; }

        ITallaRepository Tallas { get; }
        ITipoEstadoRepository TipoEstados { get; }
        ITipoPersonaRepository TipoPersonas { get; }
        ITipoProteccionRepository TipoProtecciones { get; }
        IVentaRepository Ventas { get; }
         
        Task<int> SaveAsync();
    }
}