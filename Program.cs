
//TinhTienDien.Chay();

//ThongKeDiem.Chay();

//KhoGeneric.Chay();

//ThongKeVanBan.Chay();

//string s = "trường nhân".VietHoaChuCai(); // "Trường Nhân"
//Console.WriteLine(s);

//string s = "truongnhangaren@gmail.com".LaEmailHopLe(); // true
//Console.WriteLine(s);

using HelloDotnet;
var dsV1 = SinhVien.LaySinhVienTheoDiem(8.0f);
var dsV2 = SinhVien.LaySinhVienTheoDiem2(8.0f);
var dsV3 = SinhVien.LaySinhVienTheoDiem3(8.0f);
Console.WriteLine("Danh sách sinh viên có điểm >= 8.0 (cách 1):");
foreach (var sv in dsV1)
{
    Console.WriteLine($"Mã SV: {sv.MaSV}, Họ tên: {sv.HoTen}, Điểm: {sv.Diem}, Lớp: {sv.Lop}");
}
Console.WriteLine("Danh sách sinh viên có điểm >= 8.0 (cách 2):");
foreach (var sv in dsV2)
{
    Console.WriteLine($"Mã SV: {sv.MaSV}, Họ tên: {sv.HoTen}, Điểm: {sv.Diem}, Lớp: {sv.Lop}");
}
Console.WriteLine("Danh sách sinh viên có điểm >= 8.0 (cách 3):");
foreach (var sv in dsV3)
{
    Console.WriteLine($"Mã SV: {sv.MaSV}, Họ tên: {sv.HoTen}, Điểm: {sv.Diem}, Lớp: {sv.Lop}");
}