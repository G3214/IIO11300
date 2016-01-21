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

            #region variables
            private int[] balls;
            #endregion

            #region constructors
            public Draw(int numberOfBalls)
            {
                //MessageBox.Show(String.Format("Alustettu arvo on {0}", numberOfBalls.ToString()));

                balls = Enumerable.Range(0, numberOfBalls).Select(N => N+1).ToArray();

                foreach (int i in balls)
                {

                    Debug.WriteLine(i);
                }

                Debug.WriteLine("ashfakshfkahf");
                

            }
            #endregion


            #region methods

            #endregion



        }

        public class Suomi
        {
            Draw draw = new Draw(9);
            

        }


    }
}
