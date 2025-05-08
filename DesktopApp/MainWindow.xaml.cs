namespace DesktopApp;
using System.Windows;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.Content = new Pages.SignInPage();
    }
}