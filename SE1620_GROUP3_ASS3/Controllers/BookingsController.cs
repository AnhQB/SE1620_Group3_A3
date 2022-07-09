using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            ViewData["showid"] = id;
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync()
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(booking);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            //return View(booking);
            string name = Request.Form["name"];
            string amount = Request.Form["amount"];
            int showid = Int32.Parse(Request.Form["showid"]);
            bool[] arr = new bool[100];
            for (var i = 0; i < 100; i++)
            {
                if (Request.Form[i + ""].ToString() == null || Request.Form[i + ""].ToString() == "")
                {
                    arr[i] = false;
                }
                else
                {
                    arr[i] = true;
                }
                
            }
            bool[] arrSeated = getSeatStatus(showid);
            String seatStatus = "";
            for(var i = 0; i<100; i++)
            {
                if(arrSeated[i] == true)
                {
                    arr[i] = false;
                }
                seatStatus += Convert.ToInt32(arr[i]);
            }

            Booking b = new Booking();
            b.ShowId = showid;
            b.Name = name;
            b.SeatStatus = seatStatus;
            b.Amount = Convert.ToDecimal(amount);
            _context.Add(b);
            _ = await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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

            bool[] arr = getSeatStatusByBookingID(booking.BookingId);
            ViewData["seatsStatus"] = arr;
            ViewData["booking"] = booking;
            return View();
        }

        public bool[] getSeatStatusByBookingID(int id)
        {
            var cinemaContext = _context.Bookings.Include(b => b.Show).Where(b => b.BookingId == id);
            bool[] arr = new bool[100];
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

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit()
        {
            string name = Request.Form["name"];
            string amount = Request.Form["amount"];
            int showid = Int32.Parse(Request.Form["showid"]);
            int bookingid = Int32.Parse(Request.Form["bookingid"]);
            bool[] arr = new bool[100];
            for (var i = 0; i < 100; i++)
            {
                if (Request.Form[i + ""].ToString() == null || Request.Form[i + ""].ToString() == "")
                {
                    arr[i] = false;
                }
                else
                {
                    arr[i] = true;
                }

            }
            bool[] arrSeated = getSeatStatus(showid);
            String seatStatus = "";
            for (var i = 0; i < 100; i++)
            {
                if (arrSeated[i] == true)
                {
                    arr[i] = false;
                }
                seatStatus += Convert.ToInt32(arr[i]);
            }

            Booking b = new Booking();
            b.BookingId = bookingid;
            b.ShowId = showid;
            b.Name = name;
            b.SeatStatus = seatStatus;
            b.Amount = Convert.ToDecimal(amount);
            var booking = (Booking)_context.Bookings.Where(b=>b.BookingId == bookingid);
            booking = b ;
            _ = await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
