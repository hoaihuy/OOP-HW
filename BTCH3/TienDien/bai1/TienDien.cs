using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class TienDien
    {
        protected string hotenchuho;
        protected string diachi;
        protected double socongto_cu;
        protected double socongto_moi;
       

        public TienDien() { }

        public TienDien(string ten, string dc,
            double cu, double moi)
        {
            this.hotenchuho = ten;
            this.diachi = dc;
            this.socongto_cu = cu;
            this.socongto_moi = moi;
        }

        public void Input()
        {
            Console.WriteLine("Enter the name owner of the apartment");
            this.hotenchuho = Console.ReadLine();

            Console.WriteLine("Enter address");
            this.diachi= Console.ReadLine();

            Console.WriteLine("Enter socongto_cu: ");
            this.socongto_cu =double.Parse( Console.ReadLine());

            Console.WriteLine("Enter socongto_moi: ");
            this.socongto_moi = double.Parse(Console.ReadLine());

        }

        public string Display()
        {
            return string.Format("Ten:{0}; Dia chi:{1};" +
                "So cong to thang truoc: {2};" +
                "So cong to thang nay: {3}", this.hotenchuho, this.diachi, this.socongto_cu, this.socongto_moi);
        }

        private double cong_to_dien;

        public double Cong_to_dien
        {
            get { return cong_to_dien; }
            set { cong_to_dien = value; }
        }

        public double Tinh_tien_dien()
        {
            return Cong_to_dien*1240;
        }


    }
}
