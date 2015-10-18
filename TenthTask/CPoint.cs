using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthTask
{
    class CPoint
    {
        int x;
        int y;
        public int  X
        {
          get {return x; }
          set { x = value;}
        }

        public int Y 
        {
            get { return y; }
            set { y = value; }
        }

        public CPoint() 
        {
            x = 0;
            y = 0;
        }

        public CPoint(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

       
    }
}
