using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonaXamarin_Modulo2.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _propriedadeTexto = "Texto Inicial";

        public string PropriedadeTexto
        {
            get { return _propriedadeTexto; }
            set
            {
                _propriedadeTexto = value;
                OnPropertyChanged();
            }
        }

    }
}
