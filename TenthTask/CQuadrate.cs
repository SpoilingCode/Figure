using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthTask
{
    class CQuadrate : CRectangle
    {

        public CQuadrate() :base()
       {
       }

        public CQuadrate( CPoint dotA, CPoint dotB, CPoint dotC, CPoint dotD )
           :base( dotA, dotB, dotC, dotD )
      {  
      }

      public override bool isGivenFigure()
      {
          
          if (side_AB == side_BC && side_BC == side_CD && side_CD == side_AD)
          {
              return true;
          }
          Console.WriteLine( "Данная фигура не является квадратом." );
          return false;
      }

      public override double calcArea()
      {
          return side_AB * side_AB;
      }

      

    }
}
