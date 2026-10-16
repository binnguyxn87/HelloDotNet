namespace HelloDotnet
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public double Diem { get; set; }
        public string Lop { get; set; }
        public static List<SinhVien> GetList()
        {
            return new List<SinhVien>
            {
                new SinhVien { MaSV = "SV001", HoTen = "Pham Van Dat", DiaChi = "Hue", Diem = 8.5, Tuoi = 20, Lop = "CNTT1"},
                new SinhVien { MaSV = "SV002", HoTen = "Tran Thi Lan", DiaChi = "Da Nang", Diem = 7.8, Tuoi = 19, Lop = "CNTT2"},
                new SinhVien { MaSV = "SV003", HoTen = "Le Van Nam", DiaChi = "Ha Noi", Diem = 9.2, Tuoi = 21, Lop = "CNTT1"},
                new SinhVien { MaSV = "SV004", HoTen = "Nguyen Thi Mai", DiaChi = "TP.HCM", Diem = 8.1, Tuoi = 20, Lop = "CNTT3"},
                new SinhVien { MaSV = "SV005", HoTen = "Pham Van An", DiaChi = "Hue", Diem = 7.5, Tuoi = 22, Lop = "CNTT2"}
            }; 
        }

        public static List<SinhVien> LaySinhVienTheoDiem(float diem)
        {
            List<SinhVien> dsSinhVien = GetList();
            List<SinhVien> dsKetQua = new List<SinhVien>();
            foreach (SinhVien sv in dsSinhVien)
            {
                if (sv.Diem >= diem)
                {
                    dsKetQua.Add(sv);
                }
            }
            return dsKetQua;
        }
        public static List<SinhVien> LaySinhVienTheoDiem2(float diem)
        {
            List<SinhVien> dsSinhVien = GetList();
            var rs = from sv in dsSinhVien
                     where sv.Diem >= diem
                     select sv;
            return rs.ToList();
        }
        public static List<SinhVien> LaySinhVienTheoDiem3(float diem)
        {
            List<SinhVien> dsSinhVien = GetList();
            var rs = dsSinhVien.Where(sv => sv.Diem >= diem);
            return rs.ToList();
        }
    }
}