using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();

            // Hiển thị form AddContactForm
            addContactForm.ShowDialog();  // Dùng ShowDialog để mở form như một cửa sổ modal
        }
    }
}
