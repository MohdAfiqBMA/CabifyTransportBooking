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
    public class StaffRolesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
       // public StaffRolesController(ApplicationDbContext context)
        public StaffRolesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/StaffRoles
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<StaffRole>>> GetStaffRoles()
        public async Task<IActionResult> GetStaffRoles()
        {
            return NotFound();
            var staffroles = await _unitOfWork.StaffRoles.GetAll();
            return Ok(staffroles);
            //return await _context.StaffRoles.ToListAsync();
        }

        // GET: api/StaffRoles/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<StaffRole>> GetStaffRole(int id)
        public async Task<IActionResult> GetStaffRole(int id)
        {
            //var staffrole = await _context.StaffRoles.FindAsync(id);
            var staffrole = await _unitOfWork.StaffRoles.Get(q => q.Id == id);

            if (staffrole == null)
            {
                return NotFound();
            }

            //return staffrole;
            return Ok(staffrole);
        }

        // PUT: api/StaffRoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaffRole(int id, StaffRole staffrole)
        {
            if (id != staffrole.Id)
            {
                return BadRequest();
            }

            //_context.Entry(staffrole).State = EntityState.Modified;
            _unitOfWork.StaffRoles.Update(staffrole);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!StaffRoleExists(id))
                if (!await StaffRoleExists(id))
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

        // POST: api/StaffRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StaffRole>> PostStaffRole(StaffRole staffrole)
        {
            //_context.StaffRoles.Add(staffrole);
            //await _context.SaveChangesAsync();
            await _unitOfWork.StaffRoles.Insert(staffrole);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaffRole", new { id = staffrole.Id }, staffrole);
        }

        // DELETE: api/StaffRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaffRole(int id)
        {
            //var staffrole = await _context.StaffRoles.FindAsync(id);
            var staffrole = await _unitOfWork.StaffRoles.Get(q => q.Id == id);
            if (staffrole == null)
            {
                return NotFound();
            }

            //_context.StaffRoles.Remove(staffrole);
            //await _context.SaveChangesAsync();
            await _unitOfWork.StaffRoles.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool StaffRoleExists(int id)
        private async Task<bool> StaffRoleExists(int id)
        {
            //return _context.StaffRoles.Any(e => e.Id == id);
            var staffrole = await _unitOfWork.StaffRoles.Get(q => q.Id == id);
            return staffrole != null;
        }
    }
}
