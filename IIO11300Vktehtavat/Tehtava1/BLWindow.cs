﻿using System;
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
        //private double pintaala;
        #endregion

        #region Ominaisuudet (properties)
        //oliosuunnittelun aikana on päätetty että pinta-ala ja hinta ovat read-only ominaisuuksia 

            public float Hinta
        {

            get
            {
                return LaskeHinta();
            }

        }

        public double PintaAla
        {
            get {
                return korkeus * leveys;
            }
        }
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

        private float LaskeHinta()
        {
            //hinta lasketaan työn, ja materiaalimenekin ja katteen  avulla
            float kate = 100;
            float tyo = 200;
            float materiaali;
            materiaali = 100 * (float)(leveys * korkeus) /1000000;
            return (kate + tyo + materiaali);
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
