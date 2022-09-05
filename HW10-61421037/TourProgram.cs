using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_61421037
{
    class TourProgram
    {
        //Irene Wonlopsiri 6142103726

        private string programname;
        private int avaliseat;
        private DateTime tourdate;
        private int price;

        public TourProgram (string pn, int s, DateTime td, int p)
        {
            programname = pn;
            avaliseat = s;
            tourdate = td;
            price = p;
        }

        public string ProgramName
        {
            get { return programname; }
        }
        public int AvaliSeat
        {
            get { return avaliseat; }
        }
        public DateTime TourDate
        {
            get { return tourdate; }
        }
        public int Price
        {
            get { return price; }
        }

        public void seatbooked(int s)
        {
            avaliseat -= s;
        }
        public void seatcanceled(int s)
        {
            avaliseat += s;
        }
    }
}
