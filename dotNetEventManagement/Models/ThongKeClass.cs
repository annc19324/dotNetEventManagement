using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Models
{
    public class ThongKeClass
    {
        private string ngay_dang_ky;
        private int so_luong_Don;

        public string Ngay_dang_ky
        {
            get { return ngay_dang_ky; }
            set { ngay_dang_ky = value; }
        }

        public int So_luong_Don
        {
            get { return so_luong_Don; }
            set { so_luong_Don = value; }
        }
    }

}
