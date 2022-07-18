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

namespace Shopping_list
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> ShoppinglistItems = new List<string>();

        string selectedItem;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void addItem(object sender, RoutedEventArgs e)
        {
            this.ShoppingList.Items.Add(this.newItem.Text);

            newItem.Text = "";
        }

        private void removeItem(object sender, RoutedEventArgs e)
        {
            this.ShoppingList.Items.RemoveAt(this.ShoppingList.Items.IndexOf(this.ShoppingList.SelectedItem));
        }

        private void UpdateSelectedItem(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < this.ShoppingList.Items.Count; i++)
            {
                if(this.ShoppingList.Items[i].ToString() == this.ShoppingList.SelectedValue.ToString())
                {
                    selectedItem = this.ShoppingList.Items[i].ToString();
                    newItem.Text = this.ShoppingList.Items[i].ToString();
                    break;
                }
            }
        }

        private void editItem(object sender, RoutedEventArgs e)
        {
            this.ShoppingList.Items.RemoveAt(this.ShoppingList.SelectedIndex);

            this.ShoppingList.Items.Add(this.newItem.Text);

            newItem.Text = "";
        }
    }
}
