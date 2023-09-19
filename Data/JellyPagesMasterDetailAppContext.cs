using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JellyPagesMasterDetailApp.Models;

namespace JellyPagesMasterDetailApp.Data
{
    public class JellyPagesMasterDetailAppContext : DbContext
    {
        public JellyPagesMasterDetailAppContext (DbContextOptions<JellyPagesMasterDetailAppContext> options)
            : base(options)
        {
        }

        public DbSet<JellyPagesMasterDetailApp.Models.Phonebook> Phonebook { get; set; }
    }
}
