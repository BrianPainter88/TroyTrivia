using System;
using System.Windows.Forms;
using TroyTrivia.Business.Interfaces;

namespace TroyTrivia.UI.Forms
{
    public partial class SettingsForm : Form, IDialogForm
    {
        public DialogResult PageResult { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegmentCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (false == char.IsLetterOrDigit((char) e.KeyCode))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
