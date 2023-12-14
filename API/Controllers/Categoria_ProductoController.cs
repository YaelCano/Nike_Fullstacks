using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class Categoria_ProductoController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Categoria_ProductoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Categoria_Producto>>> Get()
        {
            var entidades = await _unitOfWork.Categoria_Productos.GetAllAsync();
            return _mapper.Map<List<Categoria_Producto>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Categoria_ProductoDto>> Get(int id)
        {
            var entidad = await _unitOfWork.Categoria_Productos.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<Categoria_ProductoDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Categoria_Producto>> Post(Categoria_ProductoDto Categoria_ProductoDto)
        {
            var entidad = _mapper.Map<Categoria_Producto>(Categoria_ProductoDto);
            this._unitOfWork.Categoria_Productos.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            Categoria_ProductoDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = Categoria_ProductoDto.Id}, Categoria_ProductoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Categoria_ProductoDto>> Put(int id, [FromBody] Categoria_ProductoDto Categoria_ProductoDto)
        {
            if(Categoria_ProductoDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<Categoria_Producto>(Categoria_ProductoDto);
            _unitOfWork.Categoria_Productos.Update(entidades);
            await _unitOfWork.SaveAsync();
            return Categoria_ProductoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.Categoria_Productos.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.Categoria_Productos.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
