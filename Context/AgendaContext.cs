using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetos_dotnet_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Projetos_dotnet_MVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos{ get; set; }
    }
}