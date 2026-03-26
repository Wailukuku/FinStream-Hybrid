using FinStream_Hybrid.Data;
using FinStream_Hybrid.Dtos.Transaction;
using FinStream_Hybrid.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinStream_Hybrid.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly AppDbContext _context; 

        public TransactionsController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public  async Task<IActionResult> GetAll()
        {

            var transactions = await _context.Transactions
                    .Select(t => new TransactionResponse(
                        t.Id,
                        t.Amount,
                        t.Description,
                        t.Category,
                        t.CreatedAt))
                    .ToListAsync();
            return  Ok(transactions);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TransactionCreate request)
        {
            var transaction = new Transaction
            {
                Id = Guid.NewGuid(),
                Amount = request.Amount,
                Description = request.Description,
                Category = request.Category,
                CreatedAt = DateTime.UtcNow
            };

            await _context.AddAsync(transaction);
            await _context.SaveChangesAsync();

            var response = new TransactionResponse(
                    transaction.Id,
                    transaction.Amount,
                    transaction.Description,
                    transaction.Category,
                    transaction.CreatedAt);

            return CreatedAtAction(nameof(GetAll),
                new { id = transaction.Id }, response );
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var transaction =await _context.Transactions.FindAsync(id);

            if ( transaction == null) { 
              return NotFound();
            }

            _context.Transactions.Remove(transaction);

            await  _context.SaveChangesAsync();

            return NoContent();

        }
    }
}