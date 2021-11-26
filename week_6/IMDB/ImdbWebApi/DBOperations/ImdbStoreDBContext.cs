using System;
using Microsoft.EntityFrameworkCore;
using ImdbWebApi.DBOperations;

namespace ImdbWebApi.DBOperations {
    public class ImdbStoreDBContext : DbContext {
      
       public ImdbStoreDBContext(DbContextOptions<ImdbStoreDBContext> options) : base(options){

        }
    
        public DbSet<Imdb> Imdbs { get; set; }    
    }
    
    
}
        
        