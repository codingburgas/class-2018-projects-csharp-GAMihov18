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
using DataAccessLayer.Models;
using BussinessLogicLayer;

namespace GUI
{
	/// <summary>
	/// Interaction logic for LoginPage.xaml
	/// </summary>
	public partial class LoginPage : Page
	{
		public bool IsLoginFinished { get; private set; }
		MainWindow window;
		public LoginPage(MainWindow window)
		{
			IsLoginFinished = false;
			this.window = window;
			InitializeComponent();
			window.MainWindowFrame.Navigate(this);
		}

		private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				UserHandler.Login(UsernameTextBox.Text, PasswordTextBox.Password);
				
				IsLoginFinished = true;
				window.MainWindowFrame.Navigate(new Page());
			}
			catch (Exception)
			{
				MessageBoxButton button = MessageBoxButton.OK;
				MessageBoxImage image = MessageBoxImage.Error;
				MessageBox.Show("Incorrect username or password.\nTry Again.", "Incorrect login", button: button, icon: image);
			}

		}
		private void LoginTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				LoginButton_Click(sender, e);
			}
		}

		private void OpenRegisterWindow(object sender, MouseButtonEventArgs e)
		{
			new RegisterPage(window);
		}
	}
}
