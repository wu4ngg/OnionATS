# OnionATS
Suột được "Mượn" từ trang này https://www.c-sharpcorner.com/article/onion-architecture-in-asp-net-core-mvc/
# Cách chạy code
## Yêu cầu phần mềm
### SQL Server 2019+
https://www.microsoft.com/en-us/sql-server/sql-server-downloads
### Visual Studio 2022+
https://visualstudio.microsoft.com/
### .NET Core 8
Thường có sẵn ở phiên bản Visual Studio 2022, nếu ko thì hãy cập nhật Visual Studio bằng Visual Studio Installer.
https://learn.microsoft.com/en-us/visualstudio/install/update-visual-studio?view=vs-2022

## Các bước khởi chạy dự án
### Clone dự án
```
git clone https://github.com/wu4ngg/OnionATS
```
### Mở dự án
![ảnh](https://github.com/user-attachments/assets/f2127727-a84a-436a-9a68-6538c1c3cf02)
### Chuẩn bị database
Ở Visual Studio, vào Tools > NuGet Package Manager > Package Manager Console
Gõ lệnh
```
Update-Database
```
Nếu trường hợp lỗi, hãy cài đặt lại SQL Server
### Chạy dự án
Ấn chuột phải vào project "ATS.Web" và chọn "Configure Startup Project"\
![ảnh](https://github.com/user-attachments/assets/350ba2a8-c40f-4ef0-9948-a1d297f94518)\
Chọn "ATS.Web" và ấn OK\
![ảnh](https://github.com/user-attachments/assets/a955de6d-c379-49c1-97f8-0933d54bb190)\
Chạy đự án\
![ảnh](https://github.com/user-attachments/assets/1ebf467d-fc8f-469a-a7f6-b58310cd5462)
