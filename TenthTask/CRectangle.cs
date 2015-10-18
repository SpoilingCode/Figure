using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthTask
{
    class CRectangle
    {
       protected string nameShape;
       protected CPoint dotA, dotB, dotC, dotD;
       protected double side_AB ;
       protected double side_BC ;
       protected double side_CD;
       protected double side_AD;
       
        
       
       public CRectangle() 
       {
           nameShape = "Unknown";
           side_AB = 0;
           side_BC = 0;
           side_CD = 0;
           side_AD = 0;
           initSide();
       }

       public void outputDataOfFigure() 
       {
           Console.WriteLine( "AB = {0}\nBC = {1}\nCD = {2}\nAD = {3}", side_AB, side_BC, side_CD, side_AD );
       }

       public CRectangle( CPoint dotA, CPoint dotB, CPoint dotC, CPoint dotD ) 
       {
           this.dotA = dotA;
           this.dotB = dotB;
           this.dotC = dotC;
           this.dotD = dotD;
           initSide();
      }

       public override bool Equals(object inputObj)
       {
           if (inputObj is CRectangle) 
           {
               if ( ((CRectangle)inputObj).calcArea() == this.calcArea() )
                   return true;
           }
           return false;
       }

       public override int GetHashCode()
       {
           return this.ToString().GetHashCode();
       }

        public static bool operator == (CRectangle firstRectangle, CRectangle secondRectangle)
        {
            return firstRectangle.Equals( secondRectangle );
        }

        public static bool operator != ( CRectangle firstRectangle, CRectangle secondRectangle )
        {
            return !firstRectangle.Equals( secondRectangle );
        }
     

        public virtual bool isGivenFigure()
        {
            if ( side_AB == side_CD && side_BC == side_AD )
            {
                return true;
            }
            Console.WriteLine( "Данная фигура не является прямоугольником." );
               return false;
        }

       public  double calcLengthOfSide(CPoint firstDot, CPoint secondDot) 
       {
          double quadrateSide = Math.Pow(( secondDot.X - firstDot.X ), 2) + Math.Pow(( secondDot.Y - firstDot.Y ), 2);
          double lengthSide = Math.Sqrt( quadrateSide );
          return lengthSide;
       }

       public void initSide()
       {
           side_AB = calcLengthOfSide( dotA, dotB );
           side_CD = calcLengthOfSide( dotC ,dotD );
           side_AD = calcLengthOfSide( dotA, dotD );
           side_BC = calcLengthOfSide( dotB, dotC );
       }
       
       public double calcPerimeter() 
       {
           return side_AB + side_BC + side_CD + side_AD;
       }

       public virtual double calcArea() 
       {
           return side_AB * side_AD;
       }
       
  }
}