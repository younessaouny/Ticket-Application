﻿using Microsoft.EntityFrameworkCore;
using TicketPortal.Models;

namespace TicketPortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
