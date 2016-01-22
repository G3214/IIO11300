using System;
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

        private class Draw
        {

            #region variables 1
            private int[] balls;
            #endregion

            #region constructors 1
            public Draw(int numberOfBalls)
            {
                //MessageBox.Show(String.Format("Alustettu arvo on {0}", numberOfBalls.ToString()));

                Console.WriteLine("slfjfjal jfa");

                balls = Enumerable.Range(0, numberOfBalls).Select(N => N+1).ToArray();

                Random rnd = new Random();
                balls = balls.OrderBy(N => rnd.Next()).ToArray();


                foreach (int i in balls)
                {

                    Debug.WriteLine(i);
                }

                Debug.WriteLine("ashfakshfkahf");
                

            }
            #endregion

            #region EMPTY methods

            #endregion



        }

        public class Suomi
        {
            #region variables 1
            private static Draw draw = new Draw(39);
            #endregion

            #region constructors 1
            public Suomi()
            {

            }
            #endregion

            #region  EMTPY methods
            #endregion


        }


    }
}
