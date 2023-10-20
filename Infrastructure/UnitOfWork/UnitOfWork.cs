using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AplicationContext _context;
        private ICargoRepository _cargos { get; set; }
        private IClienteRepository _clientes { get; set; }
        private IDepartamentoRepository _departamentos { get; set; }
        private IDetalleOrdenRepository _detalleOrdenes { get; set; }
        private IDetalleVentaRepository _detalleVentas { get; set; }
        private IEmpleadoRepository _empleados { get; set; }
        private IEmpresaRepository _empresas { get; set; }
        private IEstadoRepository _estados { get; set; }
        private IFormaPagoRepository _formaPagos { get; set; }
        private IGeneroRepository _generos { get; set; }
        private IInsumoRepository _insumos { get; set; }
        private IInventarioRepository _inventarios { get; set; }
        private IMunicipioRepository _municipios { get; set; }
        private IOrdenRepository _ordenes { get; set; }
        private IPrendaRepository _prendas { get; set; }
        private IPaisRepository _paises { get; set; }
        private ITallaRepository _tallas { get; set; }
        private ITipoEstadoRepository _tipoEstados { get; set; }
        private ITipoPersonaRepository _tipoPersonas { get; set; }
        private ITipoProteccionRepository _tipoProtecciones { get; set; }
        private IVentaRepository _ventas { get; set; }


        public ICargoRepository Cargos
        {
            get
            {
                if (_cargos == null)
                {
                    _cargos = new CargoRepository(_context);
                }
                return _cargos;
            }

        }

        public IClienteRepository Clientes
        {
            get
            {
                if (_clientes == null)
                {
                    _clientes = new ClienteRepository(_context);
                }
                return _clientes;
            }

        }

        public IDepartamentoRepository Departamentos
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context);
                }
                return _departamentos;
            }

        }

        public IDetalleOrdenRepository DetalleOrdenes
        {
            get
            {
                if (_detalleOrdenes == null)
                {
                    _detalleOrdenes = new DetalleOrdenRepository(_context);
                }
                return _detalleOrdenes;
            }

        }

        public IDetalleVentaRepository DetalleVentas
        {
            get
            {
                if (_detalleVentas == null)
                {
                    _detalleVentas = new DetalleVentaRepository(_context);
                }
                return _detalleVentas;
            }

        }

        public IEmpleadoRepository Empleados
        {
            get
            {
                if (_empleados == null)
                {
                    _empleados = new EmpleadoRepository(_context);
                }
                return _empleados;
            }

        }

        public IEmpresaRepository Empresas
        {
            get
            {
                if (_empresas == null)
                {
                    _empresas = new EmpresaRepository(_context);
                }
                return _empresas;
            }

        }

        public IEstadoRepository Estados
        {
            get
            {
                if (_estados == null)
                {
                    _estados = new EstadoRepository(_context);
                }
                return _estados;
            }

        }

        public IFormaPagoRepository FormaPagos
        {
            get
            {
                if (_formaPagos == null)
                {
                    _formaPagos = new FormaPagoRepository(_context);
                }
                return _formaPagos;
            }

        }

        public IGeneroRepository Generos
        {
            get
            {
                if (_generos == null)
                {
                    _generos = new GeneroRepository(_context);
                }
                return _generos;
            }

        }


        public IInsumoRepository Insumos
        {
            get
            {
                if (_insumos == null)
                {
                    _insumos = new InsumoRepository(_context);
                }
                return _insumos;
            }

        }
        public IInventarioRepository Inventarios
        {
            get
            {
                if (_inventarios == null)
                {
                    _inventarios = new InventarioRepository(_context);
                }
                return _inventarios;
            }

        }

      

        public IMunicipioRepository Municipios
        {
            get
            {
                if (_municipios == null)
                {
                    _municipios = new MunicipioRepository(_context);
                }
                return _municipios;
            }

        }

        
        public IOrdenRepository Ordenes
        {
            get
            {
                if (_ordenes == null)
                {
                    _ordenes = new OrdenRepository(_context);
                }
                return _ordenes;
            }

        }

        public IPaisRepository Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context);
                }
                return _paises;
            }

        }

        
        public IPrendaRepository Prendas
        {
            get
            {
                if (_prendas == null)
                {
                    _prendas = new PrendaRepository(_context);
                }
                return _prendas;
            }

        }

         public ITallaRepository Tallas
        {
            get
            {
                if (_tallas == null)
                {
                    _tallas = new TallaRepository(_context);
                }
                return _tallas;
            }

        }

         public ITipoEstadoRepository TipoEstados
        {
            get
            {
                if (_tipoEstados == null)
                {
                    _tipoEstados = new TipoEstadoRepository(_context);
                }
                return _tipoEstados;
            }

        }

        
         public ITipoPersonaRepository TipoPersonas
        {
            get
            {
                if (_tipoPersonas == null)
                {
                    _tipoPersonas = new TipoPersonaRepository(_context);
                }
                return _tipoPersonas;
            }

        }

            public ITipoProteccionRepository TipoProtecciones
        {
            get
            {
                if (_tipoProtecciones == null)
                {
                    _tipoProtecciones = new TipoProteccionRepository(_context);
                }
                return _tipoProtecciones;
            }

        }

             public IVentaRepository Ventas
        {
            get
            {
                if (_ventas == null)
                {
                    _ventas = new VentaRepository(_context);
                }
                return _ventas;
            }

        }

        public IInsumoPrendaRepository InsumoPrendas => throw new NotImplementedException();

        public IIsumoProveedorRepository InsumoProveedores => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}