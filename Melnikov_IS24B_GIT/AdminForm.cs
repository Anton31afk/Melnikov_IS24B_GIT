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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), "Текущая дата и время");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мельников Антон Антонович");
        }
    }
}
