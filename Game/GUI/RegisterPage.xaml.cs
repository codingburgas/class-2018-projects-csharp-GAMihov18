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
	/// Interaction logic for RegisterPage.xaml
	/// </summary>
	public partial class RegisterPage : Page
	{
		MainWindow window;
		public RegisterPage(MainWindow window)
		{
			this.window = window;
			InitializeComponent();
			window.MainWindowFrame.Navigate(this);
		}

		private void RedirectToLoginPage(object sender, MouseButtonEventArgs e)
		{
			new LoginPage(window);
		}

		private void RegisterConfirmButton_Click(object sender, RoutedEventArgs e)
		{
			User user = new User() { Name = NameTextBox.Text, Email = EmailTextBox.Text, Password = PasswordTextBox.Text, Age = DateTime.Now.Year - AgeDatePicker.SelectedDate.Value.Year };
			UserHandler.Register(user);
		}
	}
}
