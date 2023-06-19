using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Schulte_Table
{
    public class ViewModel
    {
        GameWindow gameWindow = new GameWindow(3);
        
        public void createGameWindow(double SliderValue)
        {
            int count = 0;
            if (SliderValue == 0)
            {
                count = 3;
            }
            else if (SliderValue == 1)
            {
                count = 5;
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
