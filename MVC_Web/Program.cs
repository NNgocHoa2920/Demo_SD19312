var builder = WebApplication.CreateBuilder(args); //tạo ra ứng dụng web

// Add services to the container.
builder.Services.AddControllersWithViews(); // add các service cần
//sau này service thì bắt buộc phải add dưới var builder và trên var app

var app = builder.Build(); // chạy đối tượng web

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) // Kiểm tra co phải môi trường dev hay k
{
    app.UseExceptionHandler("/Home/Error");  //thiết lập đường dẫn
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();// cấu hình và điều hướng vs https
app.UseStaticFiles(); //sử dụng tài nguyên tĩnh/ middleware phục vụ tập tĩnh

app.UseRouting();//cấu hình đinh tuyến/ middleware định tuyến

app.UseAuthorization();//cơ chế chứng thực- phân quyền
                //su này thiết lập theo sesion colli hay người dùng
                 //middleware về xác thực


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// cáu hình cach thức truy cập action của controler
//htts:/local123/controler/action/id
app.Run();
