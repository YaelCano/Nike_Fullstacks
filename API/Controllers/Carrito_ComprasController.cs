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
public class Carrito_ComprasController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Carrito_ComprasController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Carrito_Compras>>> Get()
        {
            var entidades = await _unitOfWork.Carrito_Comprass.GetAllAsync();
            return _mapper.Map<List<Carrito_Compras>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Carrito_ComprasDto>> Get(int id)
        {
            var entidad = await _unitOfWork.Carrito_Comprass.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<Carrito_ComprasDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Carrito_Compras>> Post(Carrito_ComprasDto Carrito_ComprasDto)
        {
            var entidad = _mapper.Map<Carrito_Compras>(Carrito_ComprasDto);
            this._unitOfWork.Carrito_Comprass.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            Carrito_ComprasDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = Carrito_ComprasDto.Id}, Carrito_ComprasDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Carrito_ComprasDto>> Put(int id, [FromBody] Carrito_ComprasDto Carrito_ComprasDto)
        {
            if(Carrito_ComprasDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<Carrito_Compras>(Carrito_ComprasDto);
            _unitOfWork.Carrito_Comprass.Update(entidades);
            await _unitOfWork.SaveAsync();
            return Carrito_ComprasDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.Carrito_Comprass.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.Carrito_Comprass.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
