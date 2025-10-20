using DataEntryLibrary;

namespace DataEntryAppDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
