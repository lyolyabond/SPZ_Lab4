using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SPZ_Lab4
{
    public partial class Form1 : Form
    {
        const int N = 10;
        static string filePath;
        static string outputPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void write_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
           
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            
            using (StreamWriter sw = new StreamWriter(filePath))
                {
                    Random random = new Random();
                    for(int i = 1; i <= N; i++)
                    {
                        if (i > 1)
                        sw.Write(',');
                        sw.Write(random.Next(1, 5));
                     }
                    MessageBox.Show("В файл записана последовательность целых чисел!", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
             }
        }

        private void writeOutput_button_Click(object sender, EventArgs e)
        {
            if(filePath != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog.Filter = "out files (*.out)|*.out";
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.OverwritePrompt = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    outputPath = saveFileDialog.FileName;

                string text = File.ReadAllText(filePath);
               string[] arrayNumbers = text.Split(',');
                int count = 1;
                using(StreamWriter sw = new StreamWriter(outputPath))
                { 
               for(int i = 0; i < arrayNumbers.Length-1; i++)
                {
                    if(arrayNumbers[i] == arrayNumbers[i+1])
                    {
                        count++;
                    }
                    else
                    {
                            sw.Write(count);
                            sw.Write(',');
                            count = 1;
                    }
                    if(i == arrayNumbers.Length - 2)
                        {
                            sw.Write(count);
                        }
                    }
                }
            }
           else MessageBox.Show("Вы не выбрали исходный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void readOutput_button_Click(object sender, EventArgs e)
        {
            if(outputPath != null)
            { 
            string text = File.ReadAllText(outputPath);
            MessageBox.Show(text, "Результат");
            }
            else MessageBox.Show("Вы не выбрали файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
