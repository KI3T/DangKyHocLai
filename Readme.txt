Xin hãy làm theo các bước sau để chạy được chương trình:

Bước 1: Mở tập tin " FileSQL.sql "

*Bước 2: Ở bảng thông báo kết nối SQL copy nội dung ở khung "Sever name"

Bước 3: Connect sever SQL

Bước 4: Chuột phải thư mục "Databases" chọn Refresh vào xem có database "DangKyHocLai" chưa

Bước 5: Xóa database DangKyHocLai (nếu có) rồi Execute để chạy đoạn code

Bước 6: Mở tập tin " ltnc_CuoiKi.sln "

Bước 7: Chọn Tool trên thanh công cụ  ==> Connect to Database...

Bước 8: Nhập nội dung copy ở bước 2 vào "Server name"

Bước 9: Nhấn vào " v " ở khung "Select or enter a database name"

Bước 10: Chọn DangKyHocLai (Nếu không có quay lại bước 1)

Bước 11: Nhấn vào nút "Advanced..." ==> Copy hết "Data Soure=..."

Bước 12: Ở view "Solution Explorer" (Ctrl + Alt + L) ==> Chọn "Properties"

Bước 13: Nhấn đúp mở Settings.settings

Bước 14: Dán dữ liệu copy ở bước 11 vào ô Value

Bước 15: Ở view "Sever Explorer" (Ctrl + Alt + S)

Bước 16: Nhấn vào " (Severname của bạn).DangKyHocLai.dbo "
(Nếu có dấu " x " ở biểu tượng) - (Không phải là Azure)
- Nếu biểu tượng vẫn có dấu " x " thì nhấn nút Refresh bên trên rồi làm lại bước 11