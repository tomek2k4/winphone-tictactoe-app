using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TomaszFirstApp
{
    public class Game:INotifyPropertyChanged
    {
        private GameState[][] m_Plansza = new GameState[][]
        {
           new GameState[]{GameState.Unselected, GameState.Cross, GameState.Nought },
           new GameState[]{GameState.Unselected, GameState.Cross, GameState.Nought },
           new GameState[]{GameState.Unselected, GameState.Cross, GameState.Nought }
        };

        public GameState[][] Plansza
        {
            get
            {
                return m_Plansza;
            }
        }

        private void FirePropertyChanged(String name)
        {
            var _event = PropertyChanged;
        }

    }



}
