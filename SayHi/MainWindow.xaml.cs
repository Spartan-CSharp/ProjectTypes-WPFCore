using System.Windows;

namespace SayHi
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void SayHiButton_Click(object sender, RoutedEventArgs e)
		{
			if ( string.IsNullOrWhiteSpace(firstNameTextBox.Text) && string.IsNullOrWhiteSpace(lastNameTextBox.Text) )
			{
				sayHiTextBlock.Text = "You must enter both a First Name and a Last Name to Say Hi!";
				_ = firstNameTextBox.Focus();
			}
			else if ( string.IsNullOrWhiteSpace(firstNameTextBox.Text) )
			{
				sayHiTextBlock.Text = "You must enter a First Name to Say Hi!";
				_ = firstNameTextBox.Focus();
			}
			else if ( string.IsNullOrWhiteSpace(lastNameTextBox.Text) )
			{
				sayHiTextBlock.Text = "You must enter a Last Name to Say Hi!";
				_ = lastNameTextBox.Focus();
			}
			else
			{
				sayHiTextBlock.Text = $"Hi {firstNameTextBox.Text} {lastNameTextBox.Text}!";
				firstNameTextBox.Text = "";
				lastNameTextBox.Text = "";
				_ = firstNameTextBox.Focus();
			}
		}
	}
}
