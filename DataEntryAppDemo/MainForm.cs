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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
