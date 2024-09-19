
using Microsoft.EntityFrameworkCore;

namespace MVC_Web.Models
{
    //class này đại diện cho sql server ở trong visual studio
    public class SD19312DbContext : DbContext
    {
        //Nếu sử dụng cách 1 thì bắt buộc phải có contruct không tham số
        //C2 thì có hoặc k cũng được
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
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=NGUYEN_NGOC_HOA\\SQLEXPRESS; Database=DbSD19312" +
        //        ";Trusted_Connection = True; TrustServerCertificate= True");
        //}
        //Cách 2: để chuỗi kết nối ở phần appsetting

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Hung", DisplayOrder = 1 },
                new Category { ID = 2, Name = "Banh", DisplayOrder = 9 },
                new Category { ID = 3, Name = "Keo", DisplayOrder = 5 },
                new Category {ID = 4, Name = "Khoai", DisplayOrder = 8 },
                new Category { ID = 5, Name = "Dua hau", DisplayOrder = 5 }
                );
        }

    }
}
