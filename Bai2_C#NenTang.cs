using System;
using System.Globalization;

public static class ThongKeDiem
{
    public static void Chay()
    {
        Console.Write("Nhập số sinh viên N: ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Số sinh viên không hợp lệ!");
            return;
        }

        double[] diem = new double[n];

        // Nhập điểm và kiểm tra dữ liệu
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập điểm sinh viên {i + 1} (0-100): ");

            string? nhap = Console.ReadLine();

            bool hopLe =
                double.TryParse(nhap, NumberStyles.Float,
                    CultureInfo.CurrentCulture, out double d)
                ||
                double.TryParse(nhap, NumberStyles.Float,
                    CultureInfo.InvariantCulture, out d);

            if (!hopLe || d < 0 || d > 100)
            {
                Console.WriteLine("Điểm không hợp lệ! Hãy chạy lại và nhập điểm từ 0 đến 100.");
                return;
            }

            diem[i] = d;
        }

        // Tính điểm cao nhất, thấp nhất và trung bình
        double caoNhat = diem[0];
        double thapNhat = diem[0];
        double tong = 0;

        int gioi = 0;
        int kha = 0;
        int trungBinh = 0;
        int yeu = 0;

        Console.WriteLine("\n--- KẾT QUẢ XẾP LOẠI ---");

        for (int i = 0; i < n; i++)
        {
            if (diem[i] > caoNhat)
                caoNhat = diem[i];

            if (diem[i] < thapNhat)
                thapNhat = diem[i];

            tong += diem[i];

            string loai = diem[i] switch
            {
                >= 85 => "Giỏi",
                >= 70 => "Khá",
                >= 50 => "Trung bình",
                _ => "Yếu"
            };

            switch (loai)
            {
                case "Giỏi":
                    gioi++;
                    break;
                case "Khá":
                    kha++;
                    break;
                case "Trung bình":
                    trungBinh++;
                    break;
                default:
                    yeu++;
                    break;
            }

            Console.WriteLine(
                $"Sinh viên {i + 1}: {diem[i]} - {loai}");
        }

        Console.WriteLine("\n--- THỐNG KÊ ---");
        Console.WriteLine($"Điểm cao nhất: {caoNhat}");
        Console.WriteLine($"Điểm thấp nhất: {thapNhat}");
        Console.WriteLine($"Điểm trung bình: {tong / n:F2}");
        Console.WriteLine($"Số sinh viên Giỏi: {gioi}");
        Console.WriteLine($"Số sinh viên Khá: {kha}");
        Console.WriteLine($"Số sinh viên Trung bình: {trungBinh}");
        Console.WriteLine($"Số sinh viên Yếu: {yeu}");
    }
}