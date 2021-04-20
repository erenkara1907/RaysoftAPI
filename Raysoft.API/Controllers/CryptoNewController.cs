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
    public class CryptoNewController : CustomBaseController
    {
        private readonly IGenericService<CryptoNew, CryptoNewDto> _cryptoNewService;

        public CryptoNewController(IGenericService<CryptoNew, CryptoNewDto> cryptoNewService)
        {
            _cryptoNewService = cryptoNewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCryptoNews()
        {
            return ActionResultInstance(await _cryptoNewService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCryptoNew(int id)
        {
            return ActionResultInstance(await _cryptoNewService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCryptoNew(CryptoNewDto cryptoNewDto)
        {
            return ActionResultInstance(await _cryptoNewService.AddAsync(cryptoNewDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCryptoNew(CryptoNewDto cryptoNewDto)
        {
            return ActionResultInstance(await _cryptoNewService.Update(cryptoNewDto, cryptoNewDto.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCryptoNew(int id)
        {
            return ActionResultInstance(await _cryptoNewService.Remove(id));
        }
    }
}
