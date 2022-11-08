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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TD02;
using TP01_Qualite_Dev;

namespace TP01_Qualite_Dev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TD02.Directory directory;
        public MainWindow()
        {
            /*
             
            InitializeComponent();
            directory.NewContact(new Person("harris", "steve"));
            directory.NewContact(new Person("dickinson", "bruce"));
            directory.NewContact(new Person("murray", "dave"));
            directory.NewContact(new Person("smith", "adrian"));
            directory.NewContact(new Person("gers", "jannick"));
            directory.NewContact(new Person("mc brain", "nicko"));
            PrintList(); 
            
            */

        }
        private void PrintList()
        {
            contacts.Items.Clear(); // clear existings items
            Person[] list = directory.ListContacts();
            foreach (Person p in list)
            {
                contacts.Items.Add(p);
            }
        }

        private void AddPerson(object sender, RoutedEventArgs e)
        {
            Person p = new Person("", "");
            PersonWindow fen = new PersonWindow(p);
            if (fen.ShowDialog() == true)
            {
                directory.NewContact(p);
                PrintList();
            }

        }

        private void EditPerson(object sender, RoutedEventArgs e)
        {

        }

        private void RemPerson(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
