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
            FileNameLabelShown.Text = "..." + FileSelectionDialog.FileName.Remove(0, FileSelectionDialog.FileName.LastIndexOf('\\') + 1);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string FileContents = File.ReadAllText(FileSelectionDialog.FileName, Encoding.GetEncoding(1251));
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
            MaxDistanceBox.Enabled = true;
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
            //Обработка пользовательского ввода
            //В случае ввода некорректных данных максимальное расстояние Левенштейна считается нулевым
            if (!int.TryParse(MaxDistanceBox.Text, out int maxDist)) {
                maxDist = 0;
                MaxDistanceBox.Text = "0";
            }
            int foundWordsAmount = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < WordList.Count; i++) {
                if (Levenshtein.Levenshtein.Distance(WordSearchBox.Text, WordList[i]) <= maxDist) {
                    if (!WordListBox.Items.Contains(WordList[i])) {
                        WordListBox.BeginUpdate();
                        WordListBox.Items.Add(WordList[i]);
                        WordListBox.EndUpdate();
                    }
                    foundWordsAmount++;
                }
            }
            sw.Stop();
            ElapsedWordSearchTime.Text = sw.ElapsedTicks.ToString() + " тиков";
            switch (foundWordsAmount) {
                case 0:
                    label1.Text = "Статус поиска: Слово не найдено";
                    break;
                case 1:
                    label1.Text = "Статус поиска: Cлово найдено";
                    break;
                default:
                    label1.Text = "Статус поиска: Найдено несколько слов";
                    break;
            }
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
