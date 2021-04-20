using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Raysoft.Core.DTOs;
using Raysoft.Core.Models;
using Raysoft.Core.Services;

namespace Raysoft.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EconomistController : CustomBaseController
    {
        private readonly IGenericService<Economist, EconomistDto> _economistService;

        public EconomistController(IGenericService<Economist, EconomistDto> economistService)
        {
            _economistService = economistService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEconomist()
        {
            return ActionResultInstance(await _economistService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdEconomist(int id)
        {
            return ActionResultInstance(await _economistService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddEconomist(EconomistDto economistDto)
        {
            return ActionResultInstance(await _economistService.AddAsync(economistDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEconomist(EconomistDto economistDto)
        {
            return ActionResultInstance(await _economistService.Update(economistDto,economistDto.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEconomist(int id)
        {
            return ActionResultInstance(await _economistService.Remove(id));
        }
    }
}
