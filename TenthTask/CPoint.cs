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
            X = 0;
            Y = 0;
        }

        public CPoint(int X, int Y) 
        {
            this.X = X;
            this.Y = Y;
        }

       
    }
}
