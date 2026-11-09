using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KatalogOkienkowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Produkt> produkty = new List<Produkt>
            {
                new Produkt("Procesor intel core i9", 1500.00, "Procesory", 10),
                new Produkt("Karta graficzna nvidia geforce rtx 3080", 4000.00, "Karty graficzne", 5),
                new Produkt("Płyta główna asus rog strix z500-e", 1200.00, "Płyty główne", 8),
                new Produkt("Pamięć ram corsair vengence lpx 16gb", 499.99, "Pamięci ram", 25),
                new Produkt("Dysk ssd samsung 97b evb plus 1tb", 699.99, "Dyski ssd", 15)
            };

            EtykietaLiczbyProduktów.Text = $"{produkty.Count}";
            EtykietaWartosciMagazynu.Text = $"{Produkt.ObliczWartoscMagazynu(produkty):f2} zł";

            TextBlock dopisek = new TextBlock();
            dopisek.Text = "a";
            dopisek.FontSize = 14;
            //Glownystackpanel.Children.Add(dopisek);
        }
    }
}