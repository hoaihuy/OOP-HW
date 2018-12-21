using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đềthi
{
    class Program
    {
        static void Main(string[] args)
        {

            KhachHang kh1 = new KhachHang("Le Nguyen Hoai Huy",01288362644);
            KhachHang kh2 = new KhachHang("Nguyen Thi Le", 0983772633);

            Ve v1 = new VeNguoiLon("alpha", "PB01","TSN01", 1400,new HanhKhach("Huy",17,0123382644));
            Ve v2 = new VeCaoTuoi("beta", "PB02", "TSN02", 1400, new HanhKhach("Le", 17, 0937247220));
            Ve v3 = new VeTreEm("alpha", "PB02", "TSN02", 1400, new HanhKhach("Ha", 17, 01234557683));
            Ve v4 = new VeSinhVien("hega", "PB03", "TSN03", 1400, new HanhKhach("Hai", 17, 098782367));
            Ve v5 = new VeNguoiLon("alpha", "PB03", "TSN03", 1400, new HanhKhach("Nhi", 17, 0123382644));

            HoaDon hd1 = new HoaDon(kh1);
            HoaDon hd2 = new HoaDon(kh2);

            hd1.AddVe(v1);
            hd1.AddVe(v2);
            hd1.AddVe(v3);

            hd2.AddVe(v4);
            hd2.AddVe(v5);

            hd1.InHoaDon();

            Console.WriteLine("Tien phai tra hd1: "+hd1.TienPhaiTra());

            Console.WriteLine();
            DSHoaDon ds = new DSHoaDon();
            ds.AddHoaDon(hd1);
            ds.AddHoaDon(hd2);

            //In hóa đơn thông qua giao diện IEnumrable
            foreach (HoaDon p in ds)
                Console.WriteLine(p);

            Console.WriteLine("Tong tien cac hoa don: " + ds.Tongtien());

            //Tìm kiếm
            Console.WriteLine("Ket Qua:");
            ds.TimKiemSDT("Huy", "alpha");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
