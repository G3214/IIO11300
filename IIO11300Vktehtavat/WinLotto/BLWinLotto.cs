﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Diagnostics;

namespace WinLotto
{
    class BLWinLotto
    {
        class Global
        {
            //public string[] games = { "Lotto", "Viking", "Eurojackpot" };
        }

        private class Draw
        {

            #region variables 1
            private int[] balls;
            #endregion

            #region constructors 1
            public Draw(int numberOfBalls)
            {
               

                balls = Enumerable.Range(0, numberOfBalls).Select(N => N+1).ToArray();

                Random rnd = new Random();
                balls = balls.OrderBy(N => rnd.Next()).ToArray();
  

            }
            #endregion

            #region methods 1
            public int[] ReturnMainNumbers(int i)
            {
                //error handgling:
                if (i < balls.Length)
                {
                   //todo
                }
                return balls.Take(i).ToArray(); 

            }
            #endregion



        }

        public class Lotto
        {
            #region variables 1
            private Draw draw; // = new Draw(39);
            private ushort mainRow; //= 7;
            private ushort extraRow; //= 3;
            #endregion

            #region constructors 1
            public Lotto(ushort biggestBall, ushort mainRow, ushort extraRow)
            {

                draw = new Draw(biggestBall);
                this.mainRow = mainRow;
                this.extraRow = extraRow;




            }
            #endregion

            #region methods 1
           public int[] GetMainRow()
            {
               return  draw.ReturnMainNumbers(mainRow);
            }

            public int[] GetExtraRow()
            {
               return  draw.ReturnMainNumbers(mainRow + extraRow).Skip(mainRow).ToArray();
            }
            #endregion


        }


    }
}
