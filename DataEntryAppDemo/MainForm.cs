using DataEntryLibrary;

namespace DataEntryAppDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void nameSubmitButton_Click(object sender, EventArgs e)
        {
            var fullName = DataEntryController.FullName(
                firstNameTextBox.Text,
                lastNameTextBox.Text);
            MessageBox.Show($"You entered: {fullName}");
        }
    }
}
