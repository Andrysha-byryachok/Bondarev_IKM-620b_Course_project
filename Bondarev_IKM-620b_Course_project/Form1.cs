using System;
using System.Windows.Forms;

namespace Bondarev_IKM_620b_Course_project
{
    public partial class Form1 : Form
    {
        private bool Mode;
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
                tbInput.Enabled = false;// зміна активності Text box
                bStart.Text = "Go"; // зміна тексту на кнопці на "Стоп"
                Mode = false;
                tClock.Stop();
            }
            else
            {
                tbInput.Enabled = true;// зміна активності Text box
                bStart.Text = "Stop";// зміна тексту на кнопці на "Пуск"
                Mode = true;
                tClock.Start();
                tbInput.Focus();
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
            About A = new About(); // створення форми About
            A.tAbout.Start();
            A.ShowDialog(); // відображення діалогового вікна About
            MajorObject = new MajorWork();
            Mode = true;
        }
    }
}
 