using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public static class ThongKeVanBan
{
    public static void Chay()
    {
        string noiDung;

        try
        {
            using var reader = new StreamReader("vanban.txt");
            noiDung = reader.ReadToEnd();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Không tìm thấy tệp: {ex.FileName}");
            return;
        }

        var cacTu = Regex.Matches(
            noiDung.ToLowerInvariant(),
            @"[\p{L}\p{Nd}]+#?"
        );

        var thongKe = new Dictionary<string, int>();

        foreach (Match match in cacTu)
        {
            string tu = match.Value;

            if (thongKe.ContainsKey(tu))
                thongKe[tu]++;
            else
                thongKe[tu] = 1;
        }

        Console.WriteLine("10 từ xuất hiện nhiều nhất:");

        foreach (var item in thongKe
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .Take(10))
        {
            Console.WriteLine($"{item.Key}: {item.Value} lần");
        }
    }
}