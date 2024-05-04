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

namespace Food_Street_Menu_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        // Generate Menu Items
        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5]; // Instantiate object array with 5 menuItems objects
            string guacamolePrice;
            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();
                // First three objects in the menuItems array object referenced to all fields from ManuItem class
                if (i >= 3)
                {
                    // Last 2 objects in the menuItems sets the Breads field to a new string array
                    menuItems[i].Breads = new string[] {"plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel"};
                }
                menuItems[i].Generate();
            }
            // Assign random fields to xaml elements
            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;
            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;
            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;
            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;
            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            // Instantiate specialMenuItem object
            // Adding additional menu possibilities for last item from Menu Item
            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };
            specialMenuItem.Generate();

            // Assign random fields to xaml elements
            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            // Design a special Menu Item for the people who likes guacamole
            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;
            guacamole.Text = "Add guacamole for " + guacamoleMenuItem.Price;
        }
    }
}
