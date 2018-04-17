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
    /// Класс формы авторизации
    /// </summary>
    public partial class detali : Form
    {
        /// <summary>
        /// Объявление экземпляра класса подлкючения
        /// </summary>
        MySqlConnection cn = new MySqlConnection("server=127.0.0.1;user id=root;password=1234;port=3310;persistsecurityinfo=True;database=kal;");
        public detali()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Класс формы Детали
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kalDataSet.shlang". При необходимости она может быть перемещена или удалена.
            this.shlangTableAdapter.Fill(this.kalDataSet.shlang);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kalDataSet.chasha". При необходимости она может быть перемещена или удалена.
            this.chashaTableAdapter.Fill(this.kalDataSet.chasha);

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
        private void dobavitchasha_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into chasha(mater,cvet) values( '" + dobavmaterial.Text + "' , '" + dobavcvet.Text + "')");
            //Открытие соединения 
            cn.Open();
            //Подключение команд для работы с бд
            cmd.Connection = cn;
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            cn.Close();
            dobavmaterial.Text = "";
            dobavcvet.Text = "";
            MessageBox.Show("Чаша успешно добавлена.");
        }

        private void dobavshlang_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into shlang(mater,cvet,cena) values( '" + dobavitmaterial.Text + "' , '" + dobavitcvet.Text + "' , + '" + dobavcena.Text + "')");
            //Открытие соединения 
            cn.Open();
            //Подключение команд для работы с бд
            cmd.Connection = cn;
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            cn.Close();
            dobavitmaterial.Text = "";
            dobavitcvet.Text = "";
            dobavcena.Text = "";
            MessageBox.Show("Чаша успешно добавлена.");
        }
        /// <summary>
        /// Класс кнопки поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void poiskchasha_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (naytichasha.Text.Length > 0)
            {
                MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM chasha WHERE mater LIKE '" + naytichasha.Text + "%'", cn);
                mysda.Fill(dt);
            }
            chashi.DataSource = dt;
        }

        private void naytishlang_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (poiskshlang.Text.Length > 0)
            {
                MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM shlang WHERE mater LIKE '" + poiskshlang.Text + "%'", cn);
                mysda.Fill(dt);
            }
            shlangi.DataSource = dt;
        }
        /// <summary>
        /// Класс кнопки обновления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (naytichasha.Text.Length > 0)

            {
                MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM chasha", cn);
                mysda.Fill(dt);
            }
            chashi.DataSource = dt;
            {

            }
        }

        private void update2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (poiskshlang.Text.Length > 0)

            {
                MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM chasha", cn);
                mysda.Fill(dt);
            }
            shlangi.DataSource = dt;
        }

        private void chashi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
