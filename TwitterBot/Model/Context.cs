
using Microsoft.EntityFrameworkCore;
using TwitterBot.Model;

namespace TwitterBot.Model
{
    public class Context : DbContext
    {

        public DbSet<TweetsInfo> TweetsInfo { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)               
               optionsBuilder.UseSqlServer(@"Server=DESKTOP-QT7ODQ6\SQLEXPRESS;Database=Twitter;User Id =user_codenation;Password=12345;Trusted_Connection=False;");
           
        }


    }
}
