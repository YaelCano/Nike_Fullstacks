using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class Detalle_ProductoController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Detalle_ProductoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Detalle_Producto>>> Get()
        {
            var entidades = await _unitOfWork.Detalle_Productos.GetAllAsync();
            return _mapper.Map<List<Detalle_Producto>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Detalle_ProductoDto>> Get(int id)
        {
            var entidad = await _unitOfWork.Detalle_Productos.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<Detalle_ProductoDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Detalle_Producto>> Post(Detalle_ProductoDto Detalle_ProductoDto)
        {
            var entidad = _mapper.Map<Detalle_Producto>(Detalle_ProductoDto);
            this._unitOfWork.Detalle_Productos.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            Detalle_ProductoDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = Detalle_ProductoDto.Id}, Detalle_ProductoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Detalle_ProductoDto>> Put(int id, [FromBody] Detalle_ProductoDto Detalle_ProductoDto)
        {
            if(Detalle_ProductoDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<Detalle_Producto>(Detalle_ProductoDto);
            _unitOfWork.Detalle_Productos.Update(entidades);
            await _unitOfWork.SaveAsync();
            return Detalle_ProductoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.Detalle_Productos.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.Detalle_Productos.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
