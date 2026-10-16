using System;
using System.Collections.Generic;

// 1. Interface quy định thực thể phải có Id
public interface IThucThe
{
    int Id { get; }
}

// 2. Ngoại lệ riêng khi không tìm thấy dữ liệu
public class KhongTimThayException : Exception
{
    public KhongTimThayException(int id)
        : base($"Không tìm thấy thực thể có Id = {id}.")
    {
    }
}

// 3. Kho dữ liệu generic
public class KhoDuLieu<T> where T : IThucThe
{
    private readonly Dictionary<int, T> _duLieu = new();

    // Thêm dữ liệu
    public void Them(T thucThe)
    {
        _duLieu.Add(thucThe.Id, thucThe);
    }

    // Xóa theo Id
    public void XoaTheoId(int id)
    {
        if (!_duLieu.Remove(id))
            throw new KhongTimThayException(id);
    }

    // Tìm theo Id
    public T TimTheoId(int id)
    {
        if (_duLieu.TryGetValue(id, out var thucThe))
            return thucThe;

        throw new KhongTimThayException(id);
    }
}

// 4. Lớp ví dụ thực hiện interface IThucThe
public class SanPham : IThucThe
{
    public int Id { get; init; }
    public string Ten { get; set; } = "";
}

// 5. Chương trình thực hành
public static class KhoGeneric
{
    public static void Chay()
    {
        var kho = new KhoDuLieu<SanPham>();

        kho.Them(new SanPham { Id = 1, Ten = "Bàn phím" });
        kho.Them(new SanPham { Id = 2, Ten = "Chuột" });

        var sp = kho.TimTheoId(1);
        Console.WriteLine($"{sp.Id} - {sp.Ten}");

        kho.XoaTheoId(2);
        Console.WriteLine("Đã xóa sản phẩm có Id = 2");

        try
        {
            kho.TimTheoId(2);
        }
        catch (KhongTimThayException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}