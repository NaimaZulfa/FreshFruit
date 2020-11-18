using FreshFruit.Controller;
using FreshFruit.Model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller toni;
        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            toni = new Seller("toni", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        private void OnButton(object sender, RoutedEventArgs e)
        {

        }

        private void OnButton1Clicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            toni.addFruit(anggur);
        }

        private void OnButton2Clicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            toni.addFruit(apple);
        }

        private void OnButton3Clicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            toni.addFruit(banana);
        }

        private void OnButton4Clicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            toni.addFruit(orange);
        }
        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }
        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }
    }
}
