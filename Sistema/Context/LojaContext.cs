using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sistema.Context
{
    public class LojaContext : DbContext // passa a ser uma classe que recebe informações do DB
    {
        public DbSet<Produto> Produto { get; set; } // aceita valores do tipo model, que tem referência da classe Produto    
    }
}