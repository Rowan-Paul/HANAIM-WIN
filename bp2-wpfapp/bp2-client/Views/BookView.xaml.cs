using System.Windows;

namespace bp2_client.Views;

public partial class BookView : Window
{
    public BookView() {
        InitializeComponent();
        var viewModel = new MyViewModel();
        DataContext = viewModel;
    }
}