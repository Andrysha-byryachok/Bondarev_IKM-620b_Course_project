using System;
using System.Windows.Forms;

namespace Bondarev_IKM_620b_Course_project
{
    public partial class Form1 : Form
    {
        private bool Mode = false;
        private MajorWork MajorObject;

        public Form1()
        {
            InitializeComponent();

        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("Wake up !");
            tClock.Start();
        }

      
        private void bStart_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                tbInput.Enabled = true;// Режим дозволу введення
                tbInput.Focus();
                tClock.Start();
                bStart.Text = "STOP"; // зміна тексту на кнопці на "Стоп"
                Mode = false;
            }
            else
            {
                tbInput.Enabled = false;// Режим заборони
                tClock.Stop();
                bStart.Text = "GO ";// зміна тексту на кнопці на "Пуск"
                Mode = true;
                MajorObject.Write(tbInput.Text);// Запис даних у об'єкт
                MajorObject.Task();// Обробка даних
                label1.Text = MajorObject.Read();// Відображення результату
            }
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
            if ((e.KeyChar >= '0') & (e.KeyChar <= '9') | (e.KeyChar == (char)8))
            {
                return;
            }
            else
            {
                tClock.Stop();
                MessageBox.Show("ERROR, invalid symbol");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MajorObject = new MajorWork();
            MajorObject.SetTime();
            About A = new About(); // створення форми About
            A.tAbout.Start();
            A.ShowDialog(); // відображення діалогового вікна About 
            Mode = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string s;
            s = (System.DateTime.Now - MajorObject.GetTime()).ToString();
            MessageBox.Show(s, "Час роботи програми"); // Виведення часу роботи програми іповідомлення "Час роботи програми" на екран
        }
    }
}
 