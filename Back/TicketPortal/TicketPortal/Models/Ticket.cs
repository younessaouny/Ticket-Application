using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TicketPortal.Models
{
    public class Ticket
    {
        [Key]
        public  int ticketId {  get; set; } 
        public required string description {  get; set; }
        public bool status { get; set; }
       
        public DateTime date { get; set; }
    }
}
