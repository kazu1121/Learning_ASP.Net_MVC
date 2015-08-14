using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _07Infrastruktura.Models;

namespace _07Infrastruktura.DAL
{
    public class MessagesContext : DbContext
    {
        public MessagesContext() : base("MessagesConnectionString")
        {
            
        }

        public DbSet<MessageDetails> Messages { get; set; }
    }
}