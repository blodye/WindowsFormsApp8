using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    /// <summary>
    /// Класс формы Кальяны
    /// </summary>
    public partial class kalyan : Form
    {
        /// <summary>
        /// Объявление экземпляра класса подлкючения
        /// </summary>
        MySqlConnection cn = new MySqlConnection("server=127.0.0.1;user id=root;password=1234;port=3310;persistsecurityinfo=True;database=kal;");
        public kalyan()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kalDataSet.kalyan". При необходимости она может быть перемещена или удалена.
            this.kalyanTableAdapter.Fill(this.kalDataSet.kalyan);

        }
        /// <summary>
        /// Класс кнопки возврата назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nazad_Click(object sender, EventArgs e)
        {
            VIbor a = new VIbor();
            Hide();
            a.Show();
        }
        /// <summary>
        /// Класс кнопки добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dobavkalyanprodaja_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into kalyan(naimenovanie,cena) values( '" + dobavnaimenovanie.Text + "' , '" + dobavcena.Text + "')");
            //Открытие соединения 
            cn.Open();
            //Подключение команд для работы с бд
            cmd.Connection = cn;
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            cn.Close();
            dobavnaimenovanie.Text = "";
            dobavcena.Text = "";
            MessageBox.Show("Кальян успешно добавлен.");
        }
        /// <summary>
        /// Класс кнопки удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteprodaja_Click(object sender, EventArgs e)
        {
            kalyany.Rows.Remove(kalyany.CurrentRow);
            this.kalyanTableAdapter.Update(this.kalDataSet.kalyan);
        }
        /// <summary>
        /// Класс кнопки поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void poiskkalyan_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (poiskkalyana.Text.Length > 0)
            {
                MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM kalyan WHERE naimenovanie LIKE '" + poiskkalyana.Text + "%'", cn);
                mysda.Fill(dt);
            }
            kalyany.DataSource = dt;
        }
        /// <summary>
        /// Класс кнопки обновления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (poiskkalyana.Text.Length > 0)
            {
                MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM kalyan", cn);
                mysda.Fill(dt);
            }
            kalyany.DataSource = dt;
        }

        private void dobavnaimenovanie_TextChanged(object sender, EventArgs e)
        {

        }

        private void kalyany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
