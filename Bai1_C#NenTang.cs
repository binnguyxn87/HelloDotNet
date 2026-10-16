using System;

public static class TinhTienDien
{
    public static void Chay()
    {
        Console.Write("Nhập số kWh tiêu thụ: ");
        string? nhap = Console.ReadLine();

        if (!decimal.TryParse(nhap, out decimal kWh) || kWh < 0)
        {
            Console.WriteLine("Số kWh không hợp lệ!");
            return;
        }

        decimal tien = 0;
        decimal conLai = kWh;

        // Bậc 1: 0 - 50 kWh
        decimal bac1 = Math.Min(conLai, 50m);
        tien += bac1 * 1984m;
        conLai -= bac1;

        // Bậc 2: 51 - 100 kWh
        decimal bac2 = Math.Min(conLai, 50m);
        tien += bac2 * 2050m;
        conLai -= bac2;

        // Bậc 3: 101 - 200 kWh
        decimal bac3 = Math.Min(conLai, 100m);
        tien += bac3 * 2380m;
        conLai -= bac3;

        // Bậc 4: Trên 200 kWh
        tien += conLai * 2998m;

        Console.WriteLine($"Số điện tiêu thụ: {kWh} kWh");
        Console.WriteLine($"Tiền điện: {tien:N0} đồng");
    }
}