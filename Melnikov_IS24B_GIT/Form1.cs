using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melnikov_IS24B_GIT
{
    public partial class PR07 : Form
    {
        public PR07()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
