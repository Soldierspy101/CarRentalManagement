using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagementPE_01.Server.Data;
using CarRentalManagementPE_01.Shared.Domain;
using CarRentalManagementPE_01.Server.IRepository;
using Microsoft.Identity.Client;

namespace CarRentalManagementPE_01.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Colors
        [HttpGet]
        public async Task<IActionResult> GetColors()
        {
            var colors = await _unitOfWork.Colors.GetAll();
            return Ok(colors);

        }

        // GET: api/Colors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColors(int id)
        {
        
            var color = await _unitOfWork.Colors.Get(q => q.Id == id);

            if (color == null)
            {
                return NotFound();
            }

            return Ok(color);
        }

        // PUT: api/Colors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColous(int id, Colors color)
        {
            if (id != color.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Colors.Update(color);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColorsExists(id))
                {
                    return NotFound();
                }
            }

            return NoContent();
        }

        // POST: api/Colors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colors>> PostColors(Colors color)
        {
            await _unitOfWork.Colors.Insert(color);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColors", new { id = color.Id }, color);
        }

        // DELETE: api/Colors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColors(int id)
        {
            var color = await _unitOfWork.Colors.Get(q => q.Id == id);
            if (color == null)
            {
                return NotFound();
            }

            await _unitOfWork.Colors.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColorsExists(int id)
        {
            var color = await _unitOfWork.Colors.Get(q => q.Id == id);
            return color != null;
        }
    }
}
