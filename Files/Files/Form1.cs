using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Files {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Список слов WordList, содержащихся в файле.
        /// </summary>
        public List<string> WordList { get; set; }

        /// <summary>
        /// Создание списка слов WordList, содержащихся в файле. Активация остальных элементов управления формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSelectionDialog_FileOk(object sender, CancelEventArgs e) {
            //Сокращение полного имени файла для менее громоздкого отображения на экране
            FileNameLabelShown.Text = "..." + FileSelectionDialog.FileName.Remove(0, FileSelectionDialog.FileName.LastIndexOf('\\')+1);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string FileContents = File.ReadAllText(FileSelectionDialog.FileName);
            string[] FileWords = FileContents.Split(' ', '\n', '\r', '!', ',', '?', '—', '.', '-', ':', ';');
            List<string> list = new List<string>();
            foreach (string s in FileWords) {
                if (!list.Contains(s) && s != "") {
                    list.Add(s);
                }
            }
            WordList = list;
            sw.Stop();
            ElapsedListCreationTime.Text = sw.ElapsedTicks.ToString() + " тиков";
            WordSearchButton.Enabled = true;
            WordSearchBox.Enabled = true;
            WordListBox.Enabled = true;
            WordListBoxClearButton.Enabled = true;
        }

        /// <summary>
        /// Вызов диалога выбора текстового файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSelectionButton_Click(object sender, EventArgs e) {
            FileSelectionDialog.ShowDialog();
        }

        /// <summary>
        /// Поиск слова в списке WordList и вывод найденных слов в WordListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WordSearchButton_Click(object sender, EventArgs e) {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (WordList.Contains(WordSearchBox.Text)) {
                label1.Text = "Слово найдено";
                if (!WordListBox.Items.Contains(WordSearchBox.Text)) {
                    WordListBox.BeginUpdate();
                    WordListBox.Items.Add(WordSearchBox.Text);
                    WordListBox.EndUpdate();
                }
            }
            else {
                label1.Text = "Слово не найдено";
            }
            sw.Stop();
            ElapsedWordSearchTime.Text = sw.ElapsedTicks.ToString() + " тиков";
        }
        
        /// <summary>
        /// Реализация функционала клавиши Enter при вводе слова для поиска в окне WordSearchBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WordSearchBox_Enter(object sender, EventArgs e) {
            AcceptButton = WordSearchButton;
        }

        /// <summary>
        /// Предотвращение некорректной работы клавиши Enter при неактивном окне WordSearchBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WordSearchBox_Leave(object sender, EventArgs e) {
            AcceptButton = null;
        }

        /// <summary>
        /// Возврат состояния программы к исходному.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WordListBoxClearButton_Click(object sender, EventArgs e) {
            WordListBox.Items.Clear();
            WordList.Clear();
            FileNameLabelShown.Text = "Нет";
            WordSearchButton.Enabled = false;
            WordSearchBox.Enabled = false;
            WordListBox.Enabled = false;
            WordListBoxClearButton.Enabled = false;
        }
    }

}
