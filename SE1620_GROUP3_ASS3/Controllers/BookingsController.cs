using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SE1620_GROUP3_ASS3.Models;

namespace SE1620_GROUP3_ASS3.Controllers
{
    public class BookingsController : Controller
    {
        private readonly CinemaContext _context;

        

        public BookingsController(CinemaContext context)
        {
            _context = context;
        }



        // GET: Bookings
        public async Task<IActionResult> Index(int id)
        {
            id = 113;
            var cinemaContext = _context.Bookings.Include(b => b.Show).Where(b => b.ShowId == id);
            bool[] arr = getSeatStatus(id);
            ViewData["seatsStatus"] = arr;
            ViewData["showid"] = id;
            return View(await cinemaContext.ToListAsync());
        }

        public bool[] getSeatStatus(int id)
        {
            id = 113;
            var cinemaContext = _context.Bookings.Include(b => b.Show).Where(b => b.ShowId == id);
            bool[] arr = new bool[100];
            String s = "";
            foreach (Booking b in cinemaContext)
            {
                String seatStatus = b.SeatStatus;
                for (var i = 0; i < 100; i++)
                {
                    if (seatStatus[i] == '1' && arr[i] == false)
                    {
                        arr[i] = true;
                        continue;
                    }
                    if (arr[i] == true) continue;
                    arr[i] = false;
                }
            }
            //ViewData["seatsStatus"] = arr;
            return arr;
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Show)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create(int id)
        {
            bool[] arr = getSeatStatus(id);
            ViewData["seatsStatus"] = arr;
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,ShowId,Name,SeatStatus,Amount")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,ShowId,Name,SeatStatus,Amount")] Booking booking)
        {
            if (id != booking.BookingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Show)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}
