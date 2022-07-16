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
        ListBox listBox;
        TextBox newItemBox;

        string selectedItem;

        public MainWindow()
        {
            InitializeComponent();

            listBox = this.ShoppingList;
            newItemBox = this.newItem;
        }

        private void addItem(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(newItemBox.Text);

            newItem.Text = "";
        }

        private void removeItem(object sender, RoutedEventArgs e)
        {
            listBox.Items.RemoveAt(listBox.Items.IndexOf(listBox.SelectedItem));
        }

        private void UpdateSelectedItem(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if(listBox.Items[i].ToString() == listBox.SelectedValue.ToString())
                {
                    selectedItem = listBox.Items[i].ToString();
                    newItem.Text = listBox.Items[i].ToString();
                    break;
                }
            }
        }

        private void editItem(object sender, RoutedEventArgs e)
        {
            listBox.Items.RemoveAt(listBox.SelectedIndex);

            listBox.Items.Add(newItemBox.Text);

            newItem.Text = "";
        }
    }
}
