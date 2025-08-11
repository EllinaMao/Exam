using ProjectLogic;
using System.Collections.Generic;

namespace Task_1_Dictionary
{
    public partial class Form1 : Form
    {
        private LanguageDictionary? currentDictionary;
        private string? currentFilePath;
        private readonly string dictionariesFolder;
        public Form1()
        {
            InitializeComponent();
            dictionariesFolder = Path.Combine(Application.StartupPath , "Savefiles");
            listBoxWords.SelectedIndexChanged += listBoxWords_SelectedIndexChanged;

            // Создать папку, если её нет
            if (!Directory.Exists(dictionariesFolder))
                Directory.CreateDirectory(dictionariesFolder);
        }




        private void openFileToolStripMenuItem_Click(object sender , EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*";
            ofd.InitialDirectory = dictionariesFolder;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFilePath = ofd.FileName;
                    currentDictionary = DictionaryStorage.Load(
                        Path.GetFileName(currentFilePath) ,
                        dictionariesFolder
                    );
                    RefreshWordList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender , EventArgs e)
        {
            if (currentDictionary == null)
            {
                MessageBox.Show("Нет загруженного словаря.");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    using var sfd = new SaveFileDialog();
                    sfd.Filter = "JSON файлы (*.json)|*.json";
                    sfd.InitialDirectory = dictionariesFolder;
                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;
                    currentFilePath = sfd.FileName;
                }

                currentDictionary.Save(
                    Path.GetFileName(currentFilePath) ,
                    dictionariesFolder
                );

                MessageBox.Show("Сохранено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void RefreshWordList()
        {
            listBoxWords.Items.Clear();
            if (currentDictionary != null)
            {
                foreach (var word in currentDictionary.Words.Keys)
                {
                    listBoxWords.Items.Add(word);
                }
            }
        }
        private void listBoxWords_SelectedIndexChanged(object? sender , EventArgs e)
        {
            if (listBoxWords.SelectedItem is string selectedWord)
            {
                listBoxTranslations.Items.Clear();
                if (currentDictionary != null && currentDictionary.Words.TryGetValue(selectedWord , out var entry))
                {
                    listBoxTranslations.Items.AddRange(entry.Translations.ToArray());
                }
            }
        }

        private void listBoxTranslations_SelectedIndexChanged(object sender , EventArgs e)
        {
            if (listBoxWords.SelectedItem is string selectedWord)
            {
                listBoxTranslations.Items.Clear();

                if (currentDictionary == null)
                {
                    MessageBox.Show("Словарь не загружен.");
                    return;
                }

                try
                {
                    var translations = currentDictionary.GetTranslations(selectedWord);
                    listBoxTranslations.Items.AddRange(translations.ToArray());
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void findWordFToolStripMenuItem_Click(object sender , EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender , EventArgs e)
        {


        }

        private void replaceWordToolStripMenuItem1_Click(object sender , EventArgs e)
        {

        }

        private void addNewWordToolStripMenuItem_Click(object sender , EventArgs e)
        {

        }

        private void addTranslationToolStripMenuItem_Click(object sender , EventArgs e)
        {
            if (currentDictionary == null)
            {
                MessageBox.Show("Словарь не загружен.");
                return;
            }

            if (!(listBoxWords.SelectedItem is string selectedWord))
            {
                MessageBox.Show("Пожалуйста, выберите слово из списка.");
                return;
            }

            string newTranslation = textBoxNewTranslation.Text.Trim();
            if (string.IsNullOrEmpty(newTranslation))
            {
                MessageBox.Show("Введите перевод.");
                return;
            }

            try
            {
                currentDictionary.AddTranslation(selectedWord , newTranslation);
                // Обновляем список переводов
                listBoxTranslations.Items.Clear();
                listBoxTranslations.Items.AddRange(currentDictionary.GetTranslations(selectedWord).ToArray());

                textBoxNewTranslation.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
    
}
