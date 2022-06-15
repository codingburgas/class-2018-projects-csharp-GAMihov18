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
using BussinessLogicLayer;
namespace GUI
{
	/// <summary>
	/// Interaction logic for MainMenu.xaml
	/// </summary>
	public partial class MainMenu : Page
	{
		MainWindow window;
		public bool isUserLoggedIn;
		public MainMenu(MainWindow window, bool isLoggedIn = false)
		{
			isUserLoggedIn = isLoggedIn;
			this.window = window;
			InitializeComponent();
			if (isUserLoggedIn)
			{
				LoginRegisterButton.Visibility = Visibility.Hidden;
				UsernameLabel.Content = $"Logged in as: {UserHandler.currentlyLoggedInUser.Name}";
			}
		}
		private void LoginRegisterButton_Click(object sender, RoutedEventArgs e)
		{
			if (!isUserLoggedIn)
			{
				isUserLoggedIn = true;
				window.MainWindowFrame.Navigate(new LoginPage(window));
			}
		}
		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			window.Close();
		}
	}
}
