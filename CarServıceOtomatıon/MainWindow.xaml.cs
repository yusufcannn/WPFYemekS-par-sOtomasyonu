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


namespace FoodOtomatıon
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();  
        }
        ProductDal product = new ProductDal(); // ProductDaldan instance aldık
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           dtgDatabase.ItemsSource = product.getProducts(); // WPF yuklendiği zaman ürünleri datagrid yazdır
            
        }

        private void dtgDatabase_SelectionChanged(object sender, SelectionChangedEventArgs e) //  mouse ile urun seçme metodu
        {
            Database product = new Database(); // Database classından instance aldık
            product = (Database)dtgDatabase.SelectedItem; // seçtiğimiz ürünü product akatrdık
            grd.DataContext = product; // grid ürünleri yazdirdik
        }

        private void btEkle_Click(object sender, RoutedEventArgs e) // ürünleri Database ekleme methodu
        {
            product.addProduct(new Database { 
                ID = Convert.ToInt32(txtID.Text),
                SiparisNo =  Convert.ToInt32( txtSiparisNo.Text),
                SiparisTutarı = Convert.ToInt32(txtSiparisTutari.Text), // string veriyi int çevirdik
                SiparisAdresi = txtSiparisAdres.Text.ToString(),
                Siparis = txtSiparis.Text

            });
            dtgDatabase.ItemsSource = product.getProducts(); // eklediğimiz verileri datagrid yazdırdık

        }

        private void btGuncelle_Click(object sender, RoutedEventArgs e) // ürün güncelleme methodu
        {
            product.updateProduct(new Database
            {
                ID = Convert.ToInt32(txtID.Text),
                SiparisNo = Convert.ToInt32(txtSiparisNo.Text),
                SiparisTutarı = Convert.ToInt32(txtSiparisTutari.Text),
                SiparisAdresi = txtSiparisAdres.Text.ToString(),
                Siparis = txtSiparis.Text

            });
            dtgDatabase.ItemsSource = product.getProducts(); 
        }

        private void btSil_Click(object sender, RoutedEventArgs e) // Silme methodu
        {
            int id = Convert.ToInt32(txtID.Text); // ürün idsi
            product.deleteProduct(id);
            dtgDatabase.ItemsSource = product.getProducts();
        }

        private void txtAra_TextChanged(object sender, TextChangedEventArgs e) // arama methodu
        {
            dtgDatabase.ItemsSource = product.getProducts().Where(x => x.Siparis.ToLower().Contains(txtAra.Text.ToLower())).ToList();
            // gelenüürnleri kucuk harfe çevirdikten sonra contains methodu sayesinde kelimeyi aratıyoruz
        }
    }
}
