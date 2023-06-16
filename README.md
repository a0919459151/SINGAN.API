#  API server
- Language: .NET 7
- Database: SQL Server
- ORM: Entity Framework Core

# dev swagger
url:http://localhost:5216/swagger/index.html

## api endpoint
- GET http://localhost:5216/api/Applicant  取得申請者列表
- GET http://localhost:5216/api/Applicant/{id} 取得申請者資料
- POST http://localhost:5216/api/Applicant 新增申請者資料

# get start
## 安裝 ef 資料庫遷移工具
dotnet tool install -g dotnet-ef

    or
    
dotnet tool update -g dotnet-ef

## 設定連線字串
./appsettings.json

DefaultConnection: "Server=localhost;database=<db name>;User Id=<username>;Password=<password>;Encrypt=True;TrustServerCertificate=True;"

## db migrations (code first)
dotnet ef migrations add Init

dotnet ef database update

## run
dotnet run 
