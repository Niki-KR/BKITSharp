namespace Files {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FileSelectionButton = new System.Windows.Forms.Button();
            this.FileSelectionDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameLabelShown = new System.Windows.Forms.Label();
            this.ElapsedListCreationTimeLabel = new System.Windows.Forms.Label();
            this.ElapsedListCreationTime = new System.Windows.Forms.Label();
            this.WordSearchButton = new System.Windows.Forms.Button();
            this.WordSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WordListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParallelSearchTime = new System.Windows.Forms.Label();
            this.MaxDistanceBox = new System.Windows.Forms.TextBox();
            this.SimpleSearchButton = new System.Windows.Forms.RadioButton();
            this.ParallelSearchButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfThreadsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SimpleSearchTime = new System.Windows.Forms.Label();
            this.MakeReportButton = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FileSelectionButton
            // 
            this.FileSelectionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FileSelectionButton.Location = new System.Drawing.Point(361, 13);
            this.FileSelectionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FileSelectionButton.Name = "FileSelectionButton";
            this.FileSelectionButton.Size = new System.Drawing.Size(144, 46);
            this.FileSelectionButton.TabIndex = 0;
            this.FileSelectionButton.Text = "Выбрать файл";
            this.FileSelectionButton.UseVisualStyleBackColor = true;
            this.FileSelectionButton.Click += new System.EventHandler(this.FileSelectionButton_Click);
            // 
            // FileSelectionDialog
            // 
            this.FileSelectionDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            this.FileSelectionDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileSelectionDialog_FileOk);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 18);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(101, 13);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "Выбранный файл: ";
            // 
            // FileNameLabelShown
            // 
            this.FileNameLabelShown.AutoEllipsis = true;
            this.FileNameLabelShown.Location = new System.Drawing.Point(114, 18);
            this.FileNameLabelShown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileNameLabelShown.Name = "FileNameLabelShown";
            this.FileNameLabelShown.Size = new System.Drawing.Size(238, 13);
            this.FileNameLabelShown.TabIndex = 2;
            this.FileNameLabelShown.Text = "Нет";
            // 
            // ElapsedListCreationTimeLabel
            // 
            this.ElapsedListCreationTimeLabel.AutoSize = true;
            this.ElapsedListCreationTimeLabel.Location = new System.Drawing.Point(12, 46);
            this.ElapsedListCreationTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ElapsedListCreationTimeLabel.Name = "ElapsedListCreationTimeLabel";
            this.ElapsedListCreationTimeLabel.Size = new System.Drawing.Size(133, 13);
            this.ElapsedListCreationTimeLabel.TabIndex = 4;
            this.ElapsedListCreationTimeLabel.Text = "Время создания списка:";
            // 
            // ElapsedListCreationTime
            // 
            this.ElapsedListCreationTime.AutoSize = true;
            this.ElapsedListCreationTime.Location = new System.Drawing.Point(149, 46);
            this.ElapsedListCreationTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ElapsedListCreationTime.Name = "ElapsedListCreationTime";
            this.ElapsedListCreationTime.Size = new System.Drawing.Size(0, 13);
            this.ElapsedListCreationTime.TabIndex = 5;
            // 
            // WordSearchButton
            // 
            this.WordSearchButton.Enabled = false;
            this.WordSearchButton.Location = new System.Drawing.Point(361, 75);
            this.WordSearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WordSearchButton.Name = "WordSearchButton";
            this.WordSearchButton.Size = new System.Drawing.Size(144, 22);
            this.WordSearchButton.TabIndex = 6;
            this.WordSearchButton.Text = "Найти слово";
            this.WordSearchButton.UseVisualStyleBackColor = true;
            this.WordSearchButton.Click += new System.EventHandler(this.WordSearchButton_Click);
            // 
            // WordSearchBox
            // 
            this.WordSearchBox.Enabled = false;
            this.WordSearchBox.Location = new System.Drawing.Point(12, 76);
            this.WordSearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WordSearchBox.Name = "WordSearchBox";
            this.WordSearchBox.Size = new System.Drawing.Size(340, 20);
            this.WordSearchBox.TabIndex = 7;
            this.WordSearchBox.Text = "Введите слово для поиска";
            this.WordSearchBox.Enter += new System.EventHandler(this.WordSearchBox_Enter);
            this.WordSearchBox.Leave += new System.EventHandler(this.WordSearchBox_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Уникальных слов в файле:";
            // 
            // WordListBox
            // 
            this.WordListBox.Enabled = false;
            this.WordListBox.FormattingEnabled = true;
            this.WordListBox.Location = new System.Drawing.Point(15, 236);
            this.WordListBox.Name = "WordListBox";
            this.WordListBox.Size = new System.Drawing.Size(489, 238);
            this.WordListBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Время параллельного поиска:";
            // 
            // ParallelSearchTime
            // 
            this.ParallelSearchTime.AutoSize = true;
            this.ParallelSearchTime.Location = new System.Drawing.Point(408, 169);
            this.ParallelSearchTime.Name = "ParallelSearchTime";
            this.ParallelSearchTime.Size = new System.Drawing.Size(0, 13);
            this.ParallelSearchTime.TabIndex = 12;
            // 
            // MaxDistanceBox
            // 
            this.MaxDistanceBox.Enabled = false;
            this.MaxDistanceBox.Location = new System.Drawing.Point(398, 193);
            this.MaxDistanceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxDistanceBox.Name = "MaxDistanceBox";
            this.MaxDistanceBox.Size = new System.Drawing.Size(107, 20);
            this.MaxDistanceBox.TabIndex = 14;
            // 
            // SimpleSearchButton
            // 
            this.SimpleSearchButton.AutoSize = true;
            this.SimpleSearchButton.Checked = true;
            this.SimpleSearchButton.Enabled = false;
            this.SimpleSearchButton.Location = new System.Drawing.Point(16, 135);
            this.SimpleSearchButton.Name = "SimpleSearchButton";
            this.SimpleSearchButton.Size = new System.Drawing.Size(101, 17);
            this.SimpleSearchButton.TabIndex = 15;
            this.SimpleSearchButton.TabStop = true;
            this.SimpleSearchButton.Text = "Простой поиск";
            this.SimpleSearchButton.UseVisualStyleBackColor = true;
            // 
            // ParallelSearchButton
            // 
            this.ParallelSearchButton.AutoSize = true;
            this.ParallelSearchButton.Enabled = false;
            this.ParallelSearchButton.Location = new System.Drawing.Point(16, 165);
            this.ParallelSearchButton.Name = "ParallelSearchButton";
            this.ParallelSearchButton.Size = new System.Drawing.Size(206, 17);
            this.ParallelSearchButton.TabIndex = 16;
            this.ParallelSearchButton.Text = "Параллельный поиск (Левенштейн)";
            this.ParallelSearchButton.UseVisualStyleBackColor = true;
            this.ParallelSearchButton.CheckedChanged += new System.EventHandler(this.ParallelSearchButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Максимальное расстояние:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Количество потоков:";
            // 
            // NumberOfThreadsBox
            // 
            this.NumberOfThreadsBox.Enabled = false;
            this.NumberOfThreadsBox.Location = new System.Drawing.Point(131, 193);
            this.NumberOfThreadsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumberOfThreadsBox.Name = "NumberOfThreadsBox";
            this.NumberOfThreadsBox.Size = new System.Drawing.Size(88, 20);
            this.NumberOfThreadsBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Время простого поиска:";
            // 
            // SimpleSearchTime
            // 
            this.SimpleSearchTime.AutoSize = true;
            this.SimpleSearchTime.Location = new System.Drawing.Point(381, 137);
            this.SimpleSearchTime.Name = "SimpleSearchTime";
            this.SimpleSearchTime.Size = new System.Drawing.Size(0, 13);
            this.SimpleSearchTime.TabIndex = 21;
            // 
            // MakeReportButton
            // 
            this.MakeReportButton.Enabled = false;
            this.MakeReportButton.Location = new System.Drawing.Point(361, 105);
            this.MakeReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.MakeReportButton.Name = "MakeReportButton";
            this.MakeReportButton.Size = new System.Drawing.Size(144, 22);
            this.MakeReportButton.TabIndex = 22;
            this.MakeReportButton.Text = "Создать отчёт";
            this.MakeReportButton.UseVisualStyleBackColor = true;
            this.MakeReportButton.Click += new System.EventHandler(this.MakeReportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 486);
            this.Controls.Add(this.MakeReportButton);
            this.Controls.Add(this.SimpleSearchTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfThreadsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParallelSearchButton);
            this.Controls.Add(this.SimpleSearchButton);
            this.Controls.Add(this.MaxDistanceBox);
            this.Controls.Add(this.ParallelSearchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WordListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordSearchBox);
            this.Controls.Add(this.WordSearchButton);
            this.Controls.Add(this.ElapsedListCreationTime);
            this.Controls.Add(this.ElapsedListCreationTimeLabel);
            this.Controls.Add(this.FileNameLabelShown);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileSelectionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Поиск слов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSelectionButton;
        private System.Windows.Forms.OpenFileDialog FileSelectionDialog;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileNameLabelShown;
        private System.Windows.Forms.Label ElapsedListCreationTimeLabel;
        private System.Windows.Forms.Label ElapsedListCreationTime;
        private System.Windows.Forms.Button WordSearchButton;
        private System.Windows.Forms.TextBox WordSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox WordListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ParallelSearchTime;
        private System.Windows.Forms.TextBox MaxDistanceBox;
        private System.Windows.Forms.RadioButton SimpleSearchButton;
        private System.Windows.Forms.RadioButton ParallelSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberOfThreadsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SimpleSearchTime;
        private System.Windows.Forms.Button MakeReportButton;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

