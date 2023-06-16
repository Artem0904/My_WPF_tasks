using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Schulte_Table
{
    public class ViewModel
    {
        GameWindow gameWindow;

        public void createGameWindow(double SliderValue)
        {
            int count = 0;
            if (SliderValue == 0)
            {
                count = 9;
            }
            else if (SliderValue == 0)
            {
                count = 7;
            }
            else
            {
                count = 7;
            }
            gameWindow = new GameWindow(count);
            gameWindow.ShowDialog();
            gameWindow.Close();
        }
    }
}
