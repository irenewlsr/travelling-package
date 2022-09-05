using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_61421037
{
    class sellprogram
    {
        //Irene Wonlopsiri 6142103726

        private int cusseat;
        private TourProgram program;
        private int sumprice;

        public sellprogram(int cs, TourProgram p)
        {
            cusseat = cs;
            program = p;
            sumprice = cs * p.Price;
        }

        public int CusSeat
        {
            get { return cusseat; }
        }
        public int SumPrice
        {
            get { return sumprice; }
        }
    }
}
