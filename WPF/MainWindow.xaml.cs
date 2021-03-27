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

namespace WPF {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			// Any code goes after this line.
			txtFirstName.Text = "John";
			txtLastName.Text = "Smith";

			btnOK.Click += OnOKButtonClick;
		}

		public void OnOKButtonClick(object sender, EventArgs e) {
			// This is an event handler.
			MessageBox.Show($"Hello, {txtFirstName.Text} {txtLastName.Text}!");
		}
	}
}
