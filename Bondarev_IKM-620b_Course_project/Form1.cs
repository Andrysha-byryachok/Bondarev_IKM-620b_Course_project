using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
                gOToolStripMenuItem.Text = "STOP";
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
                gOToolStripMenuItem.Text = "GO";
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
            MajorObject.Modify = false;// заборона запису
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.ShowDialog();
        }

        private void howSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK) // Виклик діалогу збереження файлу
            {
                MajorObject.WriteSaveFileName(sfdSave.FileName); // Запис імені файлу для збереження
                MajorObject.Generator();
                MajorObject.SaveToFile(); // метод збереження в файл
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK) // Виклик діалогового вікна відкриття файлу

{
                MessageBox.Show(ofdOpen.FileName);
            }
        }

        private void aboutDrivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] Disks = System.IO.Directory.GetLogicalDrives(); // Строковий масив з логічніх дисків
            string disk = "";

            for (int i = 0; i < Disks.Length; i++)
            {
                try
                {
                    System.IO.DriveInfo D = new System.IO.DriveInfo(Disks[i]);
                    disk += D.Name + "-" + (D.TotalSize/ (int)Math.Pow(1024,3) ).ToString() + " GB -" + (D.TotalFreeSpace/ (int)Math.Pow(1024, 3)).ToString() + " GB free space" + (char)13;// змінній присвоюється ім’я диска, загальна кількість місця и вільне місце на диску
                }
                catch
                {
                    disk += Disks[i] + "- не готовий" + (char)13; // якщо пристрій не готовий, то виведення на екран ім’я пристрою і повідомлення «не готовий»
                }

            }
            MessageBox.Show(disk, "Drives");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if (MajorObject.SaveFileNameExists()) // задане ім’я файлу існує?
                    MajorObject.SaveToFile(); // зберегти дані в файл
                else
                     howSaveToolStripMenuItem_Click(sender, e); //
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajorObject.NewRec();
            tbInput.Clear();// очистити вміст тексту
            label1.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (MajorObject.Modify)
                    if (MessageBox.Show("Дані не були збережені. Продовжити вихід?", "УВАГА",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                        e.Cancel = true; // припинити закриття
        }
    }
}
 