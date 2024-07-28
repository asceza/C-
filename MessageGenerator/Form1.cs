using System;
using System.IO;

using System.Windows.Forms;

namespace MessageGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // сохранение данных из файлов в comboBox
                string[] workers = File.ReadAllLines(@"workers.txt");
                string[] placeTasks = File.ReadAllLines(@"place_tasks.txt");
                string[] typeTasks = File.ReadAllLines(@"type_tasks.txt");
                comboBoxWorkers.Items.AddRange(workers);
                comboBoxPlaceTasks.Items.AddRange(placeTasks);
                comboBoxTypeTasks.Items.AddRange(typeTasks);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проверьте наличие файлов\nworkers.txt\nplace_tasks.txt\ntype_tasks.txt");
            }
        }

        private void buttonCopyToBufer_Click(object sender, EventArgs e)
        {
            try
            {
                generateOutText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Требуется выбрать значения");
            }
        }

        private void generateOutText()
        {
            string currentWorker = comboBoxWorkers.SelectedItem.ToString();
            string currentPlaceTask = comboBoxPlaceTasks.SelectedItem.ToString();
            string currentTypeTask = comboBoxTypeTasks.SelectedItem.ToString();
            string currentComment = textBoxComment.Text;

            string outText = $"Сотрудник: {currentWorker}\n" +
                             $"Место выполнение задачи: {currentPlaceTask}\n" +
                             $"Тип задачи: {currentTypeTask}\n" +
                             $"Комментарий: {currentComment}" ;

            Clipboard.Clear(); // в случае появления ошибки
            Clipboard.SetText(outText);
        }
    }
}
