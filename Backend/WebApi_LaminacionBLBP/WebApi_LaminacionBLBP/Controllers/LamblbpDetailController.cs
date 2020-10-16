using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_LaminacionBLBP.Models;

namespace WebApi_LaminacionBLBP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LamblbpDetailController : ControllerBase
    {
        private readonly LamblbpDetailContext _context;

        public LamblbpDetailController(LamblbpDetailContext context)
        {
            _context = context;
        }

        // GET: api/LamblbpDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LamblbpDetail>>> GetLamblbpDetails()
        {
            return await _context.LamblbpDetails.ToListAsync();
        }


        // PUT: api/LamblbpDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLamblbpDetail(int id, LamblbpDetail lamblbpDetail)
        {
            if (id != lamblbpDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(lamblbpDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LamblbpDetailExists(id))
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

        // GET: api/LamblbpDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LamblbpDetail>> GetLamblbpDetail(int id)
        {
            var lamblbpDetail = await _context.LamblbpDetails.FindAsync(id);
            if (lamblbpDetail==null)
            {
                return NotFound();
            }

            return lamblbpDetail;
        }

        // POST: api/LamblbpDetail
        [HttpPost]
        public async Task<ActionResult<LamblbpDetail>> PostLamblbpDetail(LamblbpDetail lamblbpDetail)
        {
            _context.LamblbpDetails.Add(lamblbpDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLamblbpDetail", new { id = lamblbpDetail.Id }, lamblbpDetail);
        }

        // DELETE: api/LamblbpDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LamblbpDetail>> DeleteLamblbpDetail(int id)
        {
            var lamblbpDetail = await _context.LamblbpDetails.FindAsync(id);
            if (lamblbpDetail == null)
            {
                return NotFound();
            }

            _context.LamblbpDetails.Remove(lamblbpDetail);
            await _context.SaveChangesAsync();

            return lamblbpDetail;
        }

        private bool LamblbpDetailExists(int id)
        {
            return _context.LamblbpDetails.Any(e => e.Id == id);
        }
    }
}
