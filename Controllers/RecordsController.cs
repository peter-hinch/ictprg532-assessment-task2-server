using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssessmentTask2Server.DbContexts;
using AssessmentTask2Server.Models;

// This controller is generated automatically via the following process:
// 1. Right click on Controllers folder -> 'Add' -> 'New Scaffolded Item...'
// 2. Select 'API Controller with actions, using Entity Framework'
// 3. Specify Model class, Data context class and Controller name
// 4. Allow the generation process to complete. May need a 2nd attempt.
namespace AssessmentTask2Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private readonly RecordDbContext _context;

        public RecordsController(RecordDbContext context)
        {
            _context = context;
        }

        // GET: api/Records
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Record>>> GetRecords()
        {
            ActionResult<IEnumerable<Record>> records = await _context.Records.ToListAsync();

            // Generate sample data if the database is empty.
            if (_context.Records.ToList().Count() == 0)
            {
                _context.Records.Add(new Record {
                    Heading = "Amon", Description = "Description 01", 
                    Phone = "0123456789", Date = Convert.ToDateTime("01/01/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Dominik", Description = "Description 02", 
                    Phone = "0456789123", Date = Convert.ToDateTime("02/02/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Marlowe", Description = "Description 03", 
                    Phone = "0789123456", Date = Convert.ToDateTime("03/03/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Max", Description = "Description 04", 
                    Phone = "0123456789", Date = Convert.ToDateTime("04/04/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Luke", Description = "Description 05", 
                    Phone = "0456789123", Date = Convert.ToDateTime("05/05/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Jon", Description = "Description 06", 
                    Phone = "0789123456", Date = Convert.ToDateTime("06/06/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Keith", Description = "Description 07", 
                    Phone = "0123456789", Date = Convert.ToDateTime("07/07/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Zef", Description = "Description 08", 
                    Phone = "0456789123", Date = Convert.ToDateTime("08/08/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Azeem", Description = "Description 09", 
                    Phone = "0789123456", Date = Convert.ToDateTime("09/09/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Rob", Description = "Description 10", 
                    Phone = "0123456789", Date = Convert.ToDateTime("10/10/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Steve", Description = "Description 11", 
                    Phone = "0456789123", Date = Convert.ToDateTime("11/11/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Martyn", Description = "Description 12", 
                    Phone = "0789123456", Date = Convert.ToDateTime("12/12/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Don", Description = "Description 13", 
                    Phone = "0123456789", Date = Convert.ToDateTime("01/01/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Pablo", Description = "Description 14", 
                    Phone = "0456789123", Date = Convert.ToDateTime("02/02/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Zackey", Description = "Description 15", 
                    Phone = "0789123456", Date = Convert.ToDateTime("03/03/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Mike", Description = "Description 16", 
                    Phone = "0123456789", Date = Convert.ToDateTime("04/04/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Edan", Description = "Description 17", 
                    Phone = "0456789123", Date = Convert.ToDateTime("05/05/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Stacey", Description = "Description 18", 
                    Phone = "0789123456", Date = Convert.ToDateTime("06/06/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Danny", Description = "Description 19", 
                    Phone = "0123456789", Date = Convert.ToDateTime("07/07/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "David", Description = "Description 20", 
                    Phone = "0456789123", Date = Convert.ToDateTime("08/08/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Jojo", Description = "Description 21", 
                    Phone = "0789123456", Date = Convert.ToDateTime("09/09/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Jay", Description = "Description 22", 
                    Phone = "0123456789", Date = Convert.ToDateTime("10/10/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Isaiah", Description = "Description 23", 
                    Phone = "0456789123", Date = Convert.ToDateTime("11/11/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Hugh", Description = "Description 24", 
                    Phone = "0789123456", Date = Convert.ToDateTime("12/12/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Talib", Description = "Description 25", 
                    Phone = "0123456789", Date = Convert.ToDateTime("01/01/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Anderson", Description = "Description 26", 
                    Phone = "0456789123", Date = Convert.ToDateTime("02/02/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Iggy", Description = "Description 27", 
                    Phone = "0789123456", Date = Convert.ToDateTime("03/03/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Emily", Description = "Description 28", 
                    Phone = "0123456789", Date = Convert.ToDateTime("04/04/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Kanye", Description = "Description 29", 
                    Phone = "0456789123", Date = Convert.ToDateTime("05/05/2021")
                });
                _context.Records.Add(new Record {
                    Heading = "Marlena", Description = "Description 30", 
                    Phone = "0789123456", Date = Convert.ToDateTime("06/06/2021")
                });
                await _context.SaveChangesAsync();

                records = await _context.Records.ToListAsync();
            }

            return records;
        }

        // GET: api/Records/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Record>> GetRecord(long id)
        {
            var record = await _context.Records.FindAsync(id);

            if (record == null)
            {
                return NotFound();
            }

            return record;
        }

        // PUT: api/Records/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecord(long id, Record record)
        {
            if (id != record.Id)
            {
                return BadRequest();
            }

            _context.Entry(record).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecordExists(id))
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

        // POST: api/Records
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Record>> PostRecord(Record record)
        {
            _context.Records.Add(record);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecord", new { id = record.Id }, record);
        }

        // DELETE: api/Records/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Record>> DeleteRecord(long id)
        {
            var record = await _context.Records.FindAsync(id);
            if (record == null)
            {
                return NotFound();
            }

            _context.Records.Remove(record);
            await _context.SaveChangesAsync();

            return record;
        }

        private bool RecordExists(long id)
        {
            return _context.Records.Any(e => e.Id == id);
        }
    }
}
