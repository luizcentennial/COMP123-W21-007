using Exercise03.Models;
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

namespace Exercise03 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			dataAccounts.SelectionChanged += this.OnAccountSelectionChanged;
			btnCreateAccount.Click += this.OnCreateAccount;
			btnCreateTransaction.Click += this.OnCreateTransaction;

			dataAccounts.ItemsSource = this.GetAccountData();
		}

		private List<Account> GetAccountData() {
			var accounts = new List<Account>() { 
				new Account() { 
					FullName = "Bruce Wayne",
					DateOfBirth = new DateTime(1985, 7, 15),
					Transactions = new List<Transaction>() {
						new CreditTransaction() { 
							Value = 500
						},
						new CreditTransaction() {
							Value = 250
						},
						new DebitTransaction() {
							Value = 100
						},
					}
				},
				new Account() {
					FullName = "Clark Kent",
					DateOfBirth = new DateTime(1955, 2, 5),
					Transactions = new List<Transaction>() {
						new CreditTransaction() {
							Value = 350
						},
						new CreditTransaction() {
							Value = 20
						},
						new DebitTransaction() {
							Value = 75
						},
					}
				}
			};

			return accounts;
		}

		private void OnAccountSelectionChanged(object sender, SelectionChangedEventArgs e) {
			Account account = (Account)dataAccounts.SelectedItem;

			dataTransactions.ItemsSource = account.Transactions;
		}

		private void OnCreateAccount(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(txtFullName.Text) || dateDateOfBirth.SelectedDate == null) {
				MessageBox.Show("Please input all account information.");

				return;
			}

			var newAccount = new Account() { 
				FullName = txtFullName.Text,
				DateOfBirth = dateDateOfBirth.SelectedDate
			};

			// TODO: Save new account.

			var accounts = (List<Account>)dataAccounts.ItemsSource;
			accounts.Add(newAccount);

			dataAccounts.ItemsSource = null;
			dataAccounts.ItemsSource = accounts;

			txtFullName.Text = null;
			dateDateOfBirth.SelectedDate = null;
		}

		private void OnCreateTransaction(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(txtTransactionValue.Text)) {
				MessageBox.Show("Please input a transaction value.");

				return;
			}

			var transactions = (List<Transaction>)dataTransactions.ItemsSource;

			if (checkIsCredit.IsChecked == true) {
				var newTransaction = new CreditTransaction() {
					Value = double.Parse(txtTransactionValue.Text)
				};

				transactions.Add(newTransaction);
			}
			else {
				var newTransaction = new DebitTransaction() {
					Value = double.Parse(txtTransactionValue.Text)
				};

				transactions.Add(newTransaction);
			}

			// TODO: Save new transaction.

			dataTransactions.ItemsSource = null;
			dataTransactions.ItemsSource = transactions;
		}
	}
}
