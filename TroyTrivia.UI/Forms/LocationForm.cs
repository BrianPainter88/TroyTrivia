using System;
using System.Windows.Forms;
using TroyTrivia.Business.Entities;

namespace TroyTrivia.UI.Forms
{
    public partial class LocationForm : Form
    {
        public string LocationName { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public DialogResult PageResult { get; set; }

        public LocationForm()
        {
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (false == txtLocationName.Text.Trim().Length > 0)
            {
                MessageBox.Show("Location must have a value.");
                return;
            }

            LocationName = txtLocationName.Text;
            Phone = txtPhone.Text;
            Address = new Address()
            {
                Address1 = txtAddress1.Text,
                Address2 = txtAddress2.Text,
                City = txtCity.Text,
                State = txtState.Text,
                ZipCode = txtZip.Text,
                SpecialDirections = rchSpecialDirections.Text
            };


            PageResult = DialogResult.OK;
            this.Close();
        }
    }
}
