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
public class ClientesController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClientesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Clientes>>> Get()
        {
            var entidades = await _unitOfWork.Clientess.GetAllAsync();
            return _mapper.Map<List<Clientes>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClientesDto>> Get(int id)
        {
            var entidad = await _unitOfWork.Clientess.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<ClientesDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Clientes>> Post(ClientesDto ClientesDto)
        {
            var entidad = _mapper.Map<Clientes>(ClientesDto);
            this._unitOfWork.Clientess.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            ClientesDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = ClientesDto.Id}, ClientesDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClientesDto>> Put(int id, [FromBody] ClientesDto ClientesDto)
        {
            if(ClientesDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<Clientes>(ClientesDto);
            _unitOfWork.Clientess.Update(entidades);
            await _unitOfWork.SaveAsync();
            return ClientesDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.Clientess.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.Clientess.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
