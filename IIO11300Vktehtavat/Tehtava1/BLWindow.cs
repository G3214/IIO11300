using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.IIO11300
{

    public class Ikkuna
    {
        #region  Muuttujat (variables)
        private double korkeus; //taustamuuttuja
        private double leveys;
        #endregion

        #region Ominaisuudet (properties)
        public double Korkeus
        {
            get
            {
                return korkeus;
            }
            set
            {
                //tässä kohdassa voisi tarvittaessa tehdä tarkistuksia
                korkeus = value; // value on automaaginen 
            }
        }

        public double Leveys
        {
            get { return leveys; }
            set { leveys = value; }
        }




        #endregion

        #region Konstruktorit (constructors)
        #endregion

        #region Metodit (methods)
        public double LaskePintaAla()
        {
            return korkeus * leveys;
        }
        #endregion

    }



    public class IkkunaV0
    {
        //joskus tehdään näin "oikaistaa"
        public double korkeus;
        public double leveys;
        public double LaskePintaAla()
        {
            return korkeus * leveys;
        }
    }

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
