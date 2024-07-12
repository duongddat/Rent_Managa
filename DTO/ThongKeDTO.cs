using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DTO
{
    public class ThongKeDTO
    {
        public int Thang { get; set; }
        public long DoanhThu { get; set; }

        public string DisplayThang
        {
            get
            {
                return "Tháng " + Thang;
            }
        }

        public string DisplayDoanhThu
        {
            get
            {
                return DoanhThu + " đồng";
            }
        }
        public static long TinhTongDoanhThu(List<ThongKeDTO> danhSachThongKe)
        {
            long tongDoanhThu = 0;
            foreach (var thongKe in danhSachThongKe)
            {
                tongDoanhThu += thongKe.DoanhThu;
            }
            return tongDoanhThu;
        }
    }
}
