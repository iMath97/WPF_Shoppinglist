using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        const string filepath = "Shoppinglist.json";

        string selectedItem;

        public MainWindow()
        {
            InitializeComponent();
            ReadData();
        }

        public void ReadData()
        {
            string jsonString = File.ReadAllText(filepath);

            ShoppinglistItems = JsonConvert.DeserializeObject<List<string>>(jsonString);

            InitData();
        }

        public void InitData()
        {
            foreach (string item in ShoppinglistItems)
            {
                this.ShoppingList.Items.Add(item);
            }
        }

        public void WriteData()
        {
            string jsonString = JsonConvert.SerializeObject(ShoppinglistItems, Formatting.Indented);

            File.WriteAllText(filepath, jsonString);
        }

        private void addItem(object sender, RoutedEventArgs e)
        {
            this.ShoppingList.Items.Add(this.newItem.Text);
            ShoppinglistItems.Add(this.newItem.Text);

            newItem.Text = "";

            WriteData();
        }

        private void removeItem(object sender, RoutedEventArgs e)
        {
            ShoppinglistItems.RemoveAt(this.ShoppingList.Items.IndexOf(this.ShoppingList.SelectedItem));
            this.ShoppingList.Items.RemoveAt(this.ShoppingList.Items.IndexOf(this.ShoppingList.SelectedItem));

            WriteData();
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
            ShoppinglistItems[this.ShoppingList.SelectedIndex] = this.newItem.Text;
            this.ShoppingList.Items[this.ShoppingList.SelectedIndex] = this.newItem.Text;

            newItem.Text = "";

            WriteData();
        }
    }
}
