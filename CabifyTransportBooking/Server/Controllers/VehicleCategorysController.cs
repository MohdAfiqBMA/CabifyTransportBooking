using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CabifyTransportBooking.Server.Data;
using CabifyTransportBooking.Shared.Domain;
using CabifyTransportBooking.Server.IRepository;

namespace CabifyTransportBooking.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleCategorysController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
       // public VehicleCategorysController(ApplicationDbContext context)
        public VehicleCategorysController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/VehicleCategorys
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<VehicleCategory>>> GetVehicleCategorys()
        public async Task<IActionResult> GetVehicleCategorys()
        {
            var vehiclecategorys = await _unitOfWork.VehicleCategorys.GetAll();
            return Ok(vehiclecategorys);
            //return await _context.VehicleCategorys.ToListAsync();
        }

        // GET: api/VehicleCategorys/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<VehicleCategory>> GetVehicleCategory(int id)
        public async Task<IActionResult> GetVehicleCategory(int id)
        {
            //var vehiclecategory = await _context.VehicleCategorys.FindAsync(id);
            var vehiclecategory = await _unitOfWork.VehicleCategorys.Get(q => q.Id == id);

            if (vehiclecategory == null)
            {
                return NotFound();
            }

            //return vehiclecategory;
            return Ok(vehiclecategory);
        }

        // PUT: api/VehicleCategorys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleCategory(int id, VehicleCategory vehiclecategory)
        {
            if (id != vehiclecategory.Id)
            {
                return BadRequest();
            }

            //_context.Entry(vehiclecategory).State = EntityState.Modified;
            _unitOfWork.VehicleCategorys.Update(vehiclecategory);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!VehicleCategoryExists(id))
                if (!await VehicleCategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/VehicleCategorys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleCategory>> PostVehicleCategory(VehicleCategory vehiclecategory)
        {
            //_context.VehicleCategorys.Add(vehiclecategory);
            //await _context.SaveChangesAsync();
            await _unitOfWork.VehicleCategorys.Insert(vehiclecategory);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicleCategory", new { id = vehiclecategory.Id }, vehiclecategory);
        }

        // DELETE: api/VehicleCategorys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleCategory(int id)
        {
            //var vehiclecategory = await _context.VehicleCategorys.FindAsync(id);
            var vehiclecategory = await _unitOfWork.VehicleCategorys.Get(q => q.Id == id);
            if (vehiclecategory == null)
            {
                return NotFound();
            }

            //_context.VehicleCategorys.Remove(vehiclecategory);
            //await _context.SaveChangesAsync();
            await _unitOfWork.VehicleCategorys.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool VehicleCategoryExists(int id)
        private async Task<bool> VehicleCategoryExists(int id)
        {
            //return _context.VehicleCategorys.Any(e => e.Id == id);
            var vehiclecategory = await _unitOfWork.VehicleCategorys.Get(q => q.Id == id);
            return vehiclecategory != null;
        }
    }
}
