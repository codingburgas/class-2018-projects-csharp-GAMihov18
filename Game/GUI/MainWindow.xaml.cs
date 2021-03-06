using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		MainMenu mainMenu;
		LoginPage loginPage;
		RegisterPage registerPage;
		public MainWindow()
		{
			InitializeComponent();
			mainMenu = new MainMenu(this);
			MainWindowFrame.Navigate(mainMenu);
		}
	}
}
