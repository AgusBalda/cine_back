using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;
using Back.Utilities;

namespace Back.Data.Service.Services
{
    public class FuncionService : IFuncionService
    {
        private readonly IFuncionRepository _repository;
        private readonly IUtilsFuncion _utils;
        public FuncionService(IFuncionRepository repository, IUtilsFuncion utils)
        {
            _repository = repository;
            _utils = utils;
        }

        public Task<bool> Eliminar(int id)
        {
            return _repository.Delete(id);
        }

        public Task<bool> Guardar(Funcione funcione)
        {
            return _repository.Save(funcione);
        }

        public async Task<List<FuncionesDto>> ObtenerFunciones()
        {
            var ap = await _repository.GetAll();

            var FuncionessDto = ap.Select(p => new FuncionesDto
            {
                CodFuncion = p.CodFuncion ?? 0,
                HoraInicio = p.HoraInicio ?? null,
                Precio = p.Precio ?? 0,
                Subtitulo = p.Subtitulo ?? null,
                Dia = p.Dia ?? 0,
                TituloPeli = _utils.GetPelicula(p.CodPelicula ?? 0),
                IdPelicula = p.CodPelicula ?? 0,
                IdSala = p.IdSala ?? 0,
                IdPromocion = p.CodPromocion ?? 0,
                TipoFuncion = _utils.GetTipoFuncion(p.IdTipoFuncion ?? 0),
                IdTipoFuncion = p.IdTipoFuncion ?? 0,
                Estado = p.Estado ?? null


            }).ToList();
            return FuncionessDto;
            
        }

        public async Task<List<FuncionesDto>> ObtenerFuncionesPorDia(int dia)
        {
            var ap = await _repository.GetByDay(dia);

            var FuncionessDto = ap.Select(p => new FuncionesDto
            {
                CodFuncion = p.CodFuncion ?? 0,
                HoraInicio = p.HoraInicio ?? null,
                Precio = p.Precio ?? 0,
                Subtitulo = p.Subtitulo ?? null,
                Dia = p.Dia ?? 0,
                TituloPeli = _utils.GetPelicula(p.CodPelicula ?? 0),
                IdPelicula = p.CodPelicula ?? 0,
                IdSala = p.IdSala ?? 0,
                IdPromocion = p.CodPromocion ?? 0,
                TipoFuncion = _utils.GetTipoFuncion(p.IdTipoFuncion ?? 0),
                IdTipoFuncion = p.IdTipoFuncion ?? 0,
                Estado = p.Estado ?? null

            }).ToList();
            return FuncionessDto;
        }

        public async Task<FuncionesDto>? ObtenerFuncionesPorId(int id)
        {
            var p = await _repository.GetById(id);

            var FuncionessDto = new FuncionesDto()
            {
                CodFuncion = p.CodFuncion ?? 0, 
                HoraInicio = p.HoraInicio ?? null,  
                Precio = p.Precio ?? 0,  
                Subtitulo = p.Subtitulo ?? null,  
                Dia = p.Dia ?? 0,  
                TituloPeli = _utils.GetPelicula(p.CodPelicula ?? 0), 
                IdPelicula = p.CodPelicula ?? 0, 
                IdSala = p.IdSala ?? 0,  
                IdPromocion = p.CodPromocion ?? 0,  
                TipoFuncion = _utils.GetTipoFuncion(p.IdTipoFuncion ?? 0),
                IdTipoFuncion = p.IdTipoFuncion ?? 0,
                Estado = p.Estado ?? null  

            };
            return FuncionessDto;
        }
    }
}
