using Microsoft.EntityFrameworkCore;
using TicketPortal.Data;
using TicketPortal.Models;

namespace TicketPortal.Repository
{
    public class TicketRepository
    {
        private readonly AppDbContext db;

        public TicketRepository(AppDbContext dbContext)
        {
            this.db = dbContext;
        }
        public async Task<List<Ticket>> GetAllTickets()
        {
            return await db.Tickets.ToListAsync();
        }
        public async Task SaveTicket(Ticket tkt)
        {
            await db.Tickets.AddAsync(tkt);
            await db.SaveChangesAsync();
        }

        public async Task updateTicket(int id, Ticket obj)
        {
            var ticket = await db.Tickets.FindAsync(id);
            if (ticket == null)
            {
                throw new Exception("Ticket not found.");
            }
            ticket.description = obj.description;
            ticket.status = obj.status;
            ticket.date = obj.date;

            await db.SaveChangesAsync();
        }
        public async Task DeleteTicket(int id) 
        {
            var ticket = await db.Tickets.FindAsync(id);
            if (ticket == null)
            {
                throw new Exception("Ticket not found.");
            }
            db.Tickets.Remove(ticket);
            await db.SaveChangesAsync();

        }
    }
}
