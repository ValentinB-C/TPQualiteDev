using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TD02;

namespace TP01_Qualite_Dev
{
    /// <summary>
    /// Logique d'interaction pour PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        private Person p;

        public PersonWindow(Person p)
        {
            this.p = p;
        }
    }
}
