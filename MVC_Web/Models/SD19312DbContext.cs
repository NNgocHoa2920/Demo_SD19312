
using Microsoft.EntityFrameworkCore;

namespace MVC_Web.Models
{
    //class này đại diện cho sql server ở trong visual studio
    //trung gian giữa vs và sql server
    public class SD19312DbContext : DbContext
    {
        //nếu để chuỗi kết nối như cách 1 thì sẽ thêm contructor k có tham số
        public SD19312DbContext()  // vs cách 2 thì có hay k đều đc
        {
        }

        public SD19312DbContext(DbContextOptions options) : base(options)
        {
        }

        //dbset đại diện cho 1 thực thể, 1 bảng ở trong database
        //khi đụng db thì gọi đến thực thể này chứ k phải class
        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //cách add db vào sql bằng cách
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID=1, Name="Khoai1", DisplayOrder=1},
                new Category { CategoryID = 2, Name = "Khoai2", DisplayOrder = 2 },
                new Category { CategoryID = 3, Name = "Khoai3", DisplayOrder = 10 },
                new Category { CategoryID = 4, Name = "Khoai4", DisplayOrder = 9 },
                new Category { CategoryID = 5, Name = "Khoai5", DisplayOrder = 8}
                );
        }
        //cách 1: để chuỗi kết nối ở đây
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=NGUYEN_NGOC_HOA\\HOANN; Database=DbSD19312" +
        //        ";Trusted_Connection = True; TrustServerCertificate= True");
        //}
        //cách 2: config chuỗi kết nối ở appsetting, vvaf k cần thiết phải cos contructor k có tham số
        // nhớ add service ở program





    }
}
