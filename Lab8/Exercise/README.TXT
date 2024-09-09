Giới thiệu
    - Đây là ví dụ ASP.NET MVC Core thực hiện CRUD trên Product, có dùng entity framework core để lưu dữ liệu
    - Database được dùng là docker trên macOS (Azure Edge)
    - Để chạy chương trình:
        
        + Vào Program.cs, chỉnh lại connection string ở dòng 15 cho phù hợp với database ở máy đang sử dụng
        + dotnet ef database update: để cập nhật database
        + dotnet run