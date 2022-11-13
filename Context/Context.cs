using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using bootcamp_potencial_net_developer_dio_mvc.Models;

namespace bootcamp_potencial_net_developer_dio_mvc.Context
{
  public class Context : DbContext
  {
    public Context(DbContextOptions<Context> options) : base(options) { }

    public DbSet<Contato> Contatos { get; set; }
  }
}