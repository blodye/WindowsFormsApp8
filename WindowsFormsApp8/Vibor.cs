using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    /// <summary>
    /// Класс формы Выбора
    /// </summary>
    public partial class VIbor : Form
    {
        public VIbor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Класс кнопки добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dobavitkalyan_Click(object sender, EventArgs e)
        {
            kalyan a = new kalyan();
            Hide();
            a.Show();
        }

        private void dobavitdetali_Click(object sender, EventArgs e)
        {
            detali a = new detali();
            Hide();
            a.Show();
        }
    }
}
