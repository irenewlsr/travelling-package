using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW10_61421037
{
    class customer
    {
        //Irene Wonlopsiri 6142103726

        private string cusname;
        private string phoneno;
        private int cusseat;
        private int programchosen;
        private int serviceno;
        private ArrayList sell;
        private int totprice;

        public customer (string cn, string no, int cs, int p, int sn)
        {
            cusname = cn;
            phoneno = no;
            cusseat = cs;
            programchosen = p;
            serviceno = sn;
            sell = new ArrayList();
        }

        public int ServiceNo
        {
            get { return serviceno; }
        }
        public int CusSeat
        {
            get { return cusseat; }
        }
        public int ProgramChosen
        {
            get { return programchosen; }
        }

        public int booktour(int cn, TourProgram p)
        {
            sellprogram s = new sellprogram(cn, p);

            if (s.CusSeat <= p.AvaliSeat)
            {
                totprice = s.SumPrice;
                return totprice;
            }

            else
            {
                Console.WriteLine("This program is already full");
                return 0;
            }
        }

        public void canceltour(DateTime ct, TourProgram p)
        {
            int daysleft;
            string days;
            TimeSpan t = p.TourDate - ct;
            days = t.Days.ToString();
            daysleft = Convert.ToInt32(days);

            if(daysleft >= 7)
            {
                double refund = 0.7 * totprice;
                Console.WriteLine("Your refund is " + refund + "Bht");
            }
            else
            {
                Console.WriteLine("You cant get the refund.");
            }
        }
    }
}
