using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_backend.Models;

namespace test_backend.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MontyHallController : ControllerBase
	{

		private readonly MontyHallDbContext _context;

		public MontyHallController(MontyHallDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<MontyHallGameResult>>> GetMontyHallResult()
		{
			return await _context.MontyHall.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<MontyHallGameResult>> PostMontyHallResult(MontyHallGameResult montyHallGameResult)
		{
			_context.MontyHall.Add(montyHallGameResult);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetMontyHallResult", new { id = montyHallGameResult.Id }, montyHallGameResult);
		}

	}
}
