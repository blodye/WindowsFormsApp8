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
    public partial class auto : Form
    {
        /// <summary>
        /// Объявление экземпляра класса подлкючения
        /// </summary>
        MySqlConnection cn = new MySqlConnection("server=127.0.0.1;user id=root;password=1234;port=3310;persistsecurityinfo=True;database=kal;");
        public auto()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Класс кнопки авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vhod_Click(object sender, EventArgs e)
        {
            //запрос на выбор из таблицы user столбцов Email и parol
            MySqlCommand cmd = new MySqlCommand("select * from user where Email = '" + login.Text + "' and parol = '" + parol.Text + "'");
            //Открытие соединения 
            cn.Open();
            //Подключение команд для работы с бд
            cmd.Connection = cn;
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            try
            {
                //Сравнения textbox с полями таблицы
                if (read[1].ToString() == login.Text && read[2].ToString() == parol.Text)
                {
                    ///Вывод надписи на экран
                    MessageBox.Show("Вход выполнен");
                    switch (read[3].ToString())
                    {
                        //Открытие форм в соответсвии с их ролями
                        case "1":
                            VIbor Manager = new VIbor();
                            Hide();
                            Manager.Show();
                            break;
                        
                        
                    }
                }
            }
            ///Обработчик событий
            catch
            {
                MessageBox.Show("Вход не выполнен, повторите попытку");
            }
            cn.Close();
        }


        
    }
    }

