using CustomerApp.Data;
using SQLite;
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

namespace CustomerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window{
    private List<Customer> _customer = new List<Customer>();

    public MainWindow()    {
        InitializeComponent();
        ReadDatabase();

        CustomerListView.ItemsSource = _customer;
    }

    private void ReadDatabase() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            _customer = connection.Table<Customer>().ToList();
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e) {
        var customer = new Customer() {
            Name = NameTextBox.Text,
            Phone = PhoneTextBox.Text,
            Address = AddressTextBox.Text
        };
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Customer>();
            connection.Insert(customer);
        }
    }

    private void UpdataButton_Click(object sender, RoutedEventArgs e) {
        ReadDatabase();
        CustomerListView.ItemsSource = _customer;
    }

    private void deleteButton_Click(object sender, RoutedEventArgs e) {
        var item = CustomerListView.SelectedItem as Customer;
        if (item == null) {
            MessageBox.Show("行を選択してください");
            return;
        }
    }
}