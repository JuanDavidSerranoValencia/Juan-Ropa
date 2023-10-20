using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class InsumoController:BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InsumoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<InsumoDto>>> Get()
        {
            var pais = await _unitOfWork.Paises.GetAllAsync();
          
            return _mapper.Map<List<InsumoDto>>(pais);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pais>> Post(InsumoDto paisDto)
        {
            var pais = _mapper.Map<Pais>(paisDto);
            this._unitOfWork.Paises.Add(pais);
            await _unitOfWork.SaveAsync();
            if (pais == null)
            {
                return BadRequest();
            }
            paisDto.Id = pais.Id;
            return CreatedAtAction(nameof(Post), new { id = paisDto.Id }, paisDto);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InsumoDto>> Get(int id)
        {
            var pais = await _unitOfWork.Paises.GetByIdAsync(id);
            if (pais == null)
            {
                return NotFound();
            }
            return _mapper.Map<InsumoDto>(pais);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<InsumoDto>> Put(int id, [FromBody] InsumoDto paisDto)
        {
            if (paisDto == null)
                return NotFound();
            var pais = _mapper.Map<Pais>(paisDto);
            _unitOfWork.Paises.Update(pais);
            await _unitOfWork.SaveAsync();
            return paisDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var pais = await _unitOfWork.Paises.GetByIdAsync(id);
            if (pais == null)
            {
                return NotFound();
            }
            _unitOfWork.Paises.Remove(pais);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}