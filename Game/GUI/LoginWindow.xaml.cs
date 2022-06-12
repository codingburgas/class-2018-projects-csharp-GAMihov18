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
using System.Windows.Shapes;
using DataAccessLayer.Models;
using BussinessLogicLayer;
namespace GUI
{
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		public bool IsLoginFinished { get; private set; }
		public object Lock { get; }
		MainWindow window;
		public LoginWindow(MainWindow window)
		{
			Lock = new object();
			IsLoginFinished = false;
			this.window = window;
			InitializeComponent();
		}

		private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				UserHandler.Login(UsernameTextBox.Text, PasswordTextBox.Text);
				lock (Lock)
				{
					IsLoginFinished = true;
					Close();
					window.Show();
					window.NameLabel.Content = UserHandler.currentlyLoggedInUser.Name;
				}
			}
			catch (Exception)
			{

			}
			
		}
	}
}
