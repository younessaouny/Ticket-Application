using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketPortal.Models;
using TicketPortal.Repository;

namespace TicketPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketRepository tkt;
        public TicketController(TicketRepository ticketRepository)
        {
            this.tkt = ticketRepository;
        }
        [HttpGet]
        public async Task<ActionResult> TicketList()
        {
            var allTickets = await tkt.GetAllTickets();
            return Ok(allTickets);
        }
        [HttpPost]
        public async Task<ActionResult> AddTicket(Ticket vm)
        {
            vm.date = DateTime.Now;
            await tkt.SaveTicket(vm);
            return Ok(vm);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> updateTicket(int id, [FromBody] Ticket vm)
        {
            vm.date = DateTime.Now;
            await tkt.updateTicket(id, vm);
            return Ok(vm);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> deleteTicket(int id)
        {
            await tkt.DeleteTicket(id);
            return Ok();
        }
    }
}
