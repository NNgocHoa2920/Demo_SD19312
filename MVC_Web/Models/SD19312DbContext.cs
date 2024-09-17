
using Microsoft.EntityFrameworkCore;

namespace MVC_Web.Models
{
    //class này đại diện cho sql server ở trong visual studio
    public class SD19312DbContext : DbContext
    {
        public SD19312DbContext()
        {
        }

        public SD19312DbContext(DbContextOptions options) : base(options)
        {
        }

        //dbset đại diện cho 1 thực thể, 1 bảng ở trong database
        //khi đụng db thì gọi đến thực thể này chứ k phải class
        public DbSet<Category> Categories{ get; set; }
        //cách 1: để chuỗi kết nối ở đây
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NGUYEN_NGOC_HOA\\SQLEXPRESS; Database=DbSD19312" +
                ";Trusted_Connection = True; TrustServerCertificate= True");
        }

        

    }
}
