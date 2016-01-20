using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    public class BusinessLogicWindow
    {
        /// <summary>
        /// CalculatePerimeter calculates the perimeter of a window
        /// </summary>
        public static double CalculatePerimeter(double widht, double height)
        {
            return (widht * 2) + (height * 2);
            throw new System.NotImplementedException();
        }


        public static double CalculateWindowArea(double widht, double height, double frame)
        {
            return (widht - frame) * (height - frame);
            throw new System.NotImplementedException();
        }

        public static double CalculateFrameArea(double widht, double height, double frame)
        {
            return (widht*height) - CalculateWindowArea(widht, height, frame);
            //return 3.0;
        }



    }
}
