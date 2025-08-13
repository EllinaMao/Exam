using ProjectLogic;
using System.Collections.Generic;
using System.Transactions;

namespace Task_1_Dictionary
{
    public partial class Form1 : Form
    {
        private LanguageDictionary? currentDictionary;
        private string? currentFilePath;
        private readonly string dictionariesFolder;
        private readonly string wordsExportFolder;
        public Form1()
        {
            InitializeComponent();
            dictionariesFolder = Path.Combine(Application.StartupPath , "Savefiles");
            wordsExportFolder = Path.Combine(Application.StartupPath , "Translations");

            //слежение за выбором текста и перевода
            listBoxWords.SelectedIndexChanged += listBoxWords_SelectedIndexChanged;
            listBoxTranslations.SelectedIndexChanged += listBoxTranslations_SelectedIndexChanged;

            // (имена кнопок: addNew, ChangeSelected, deleteSelected, saveToFile)
            // Назначение обработчиков событий для кнопок
            this.KeyPreview = true;
            this.KeyDown += Dictionary_KeyDown;
            // Создать папку, если её нет
            if (!Directory.Exists(dictionariesFolder))
                Directory.CreateDirectory(dictionariesFolder);
            if (!Directory.Exists(wordsExportFolder))
                Directory.CreateDirectory(wordsExportFolder);
        }

        private void Dictionary_KeyDown(object? sender , KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.N)
            {
                createNewFileToolStripMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                openFileToolStripMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                saveFileToolStripMenuItem_Click(sender, e);
            }
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
                    RefreshTranslations();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            if (currentDictionary == null)
            {
                MessageBox.Show("Не удалось загрузить словарь.");
                return;
            }
            if (currentDictionary?.Words == null || currentDictionary.Words.Count == 0)
            {
                panelButtons.Visible = true;
            }
            else
            {
                panelButtons.Visible = false;
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
        private void RefreshTranslations()
        {
            listBoxTranslations.Items.Clear();
            if (listBoxWords.SelectedItem is string selectedWord && currentDictionary != null)
            {
                if (currentDictionary.Words.TryGetValue(selectedWord , out var entry))
                {
                    listBoxTranslations.Items.AddRange(entry.Translations.ToArray());
                }
            }
        }

        private void listBoxWords_SelectedIndexChanged(object? sender , EventArgs e)
        {
            if (listBoxWords.SelectedItem is string selectedWord)
            {
                panelButtons.Visible = true;
                listBoxTranslations.Items.Clear();
                if (currentDictionary != null && currentDictionary.Words.TryGetValue(selectedWord , out var entry))
                {
                    listBoxTranslations.Items.AddRange(entry.Translations.ToArray());
                }
                saveToFile.Tag = selectedWord; // Сохраняем выбранное слово в теге кнопки
            }
        }
        private void listBoxTranslations_SelectedIndexChanged(object? sender , EventArgs e)
        {

            if (listBoxTranslations.SelectedItem is string selectedTranslation)
            {
                //
            }

        }

        private void addNew_Click(object sender , EventArgs e)
        {
            try
            {
                if (listBoxTranslations.SelectedItem is string translation && listBoxWords.SelectedItem is string word)
                {
                    addNewTranslation(sender , e);
                }
                else if (listBoxWords.SelectedItem == null || listBoxWords.SelectedItem is string oldWord)
                {
                    addNewWord(sender , e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
            }

        }

        private void addNewTranslation(object sender , EventArgs e)
        {
            try
            {
                if (listBoxTranslations.SelectedItem is string translation && listBoxWords.SelectedItem is string word && currentDictionary != null)
                {
                    string? newTranslation = Prompt.ShowDialog("Введите новый перевод:" , "Изменить перевод");
                    currentDictionary.AddTranslation(word , newTranslation);
                    RefreshTranslations();
                    listBoxTranslations.SelectedItem = newTranslation;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка при добавлении перевода: " + ex.Message);
            }

        }

        private void addNewWord(object sender , EventArgs e)
        {
            string? newWord = Prompt.ShowDialog("Введите новое слово:" , "Добавить слово");
            if (string.IsNullOrWhiteSpace(newWord)) return;

            string? firstTrans = Prompt.ShowDialog("Введите первый перевод для слова:" , "Добавить перевод");
            if (string.IsNullOrWhiteSpace(firstTrans)) return;

            try
            {
                if (currentDictionary == null)
                    currentDictionary = new LanguageDictionary("New dictionary");

                currentDictionary.AddWord(newWord , new List<string> { firstTrans });
                RefreshWordList();
                listBoxWords.SelectedItem = newWord;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка при добавлении слова: " + ex.Message);
            }

        }

        private void change_Click(object sender , EventArgs e)
        {
            try
            {
                if (listBoxTranslations.SelectedItem is string translation && listBoxWords.SelectedItem is string word)
                {
                    changeTranslation(sender , e);
                }
                else if (listBoxWords.SelectedItem is string oldWord)
                {
                    changeWord(sender , e);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
            }


        }

        private void changeWord(object sender , EventArgs e)
        {
            string? newWord = Prompt.ShowDialog("Введите новое слово:" , "Добавить слово");
            try
            {
                string? word = listBoxWords.SelectedItem as string;
                currentDictionary.ReplaceWord(word , newWord);
                RefreshWordList();
                listBoxWords.SelectedItem = newWord;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка при добавлении слова: " + ex.Message);
            }
        }

        private void changeTranslation(object sender , EventArgs e)
        {
            try
            {
                string? newTranslation = Prompt.ShowDialog("Введите новый перевод:" , "Изменить перевод");
                if (string.IsNullOrWhiteSpace(newTranslation)) return;
                string? word = listBoxWords.SelectedItem as string;
                string? translation = listBoxTranslations.SelectedItem as string;
                currentDictionary.ReplaceTranslation(word , translation , newTranslation);
                RefreshTranslations();
                listBoxTranslations.SelectedItem = newTranslation;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка при изменении перевода: " + ex.Message);
            }
        }

        private void remove_Click(object sender , EventArgs e)
        {
            try
            {
                if (listBoxTranslations.SelectedItem is string translation && listBoxWords.SelectedItem is string word)
                {
                    removeTranslation(sender , e);
                }
                else if (listBoxWords.SelectedItem is string oldWord)
                {
                    removeWord(sender , e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message);
            }

        }

        private void removeWord(object sender , EventArgs e)
        {
            var word = listBoxWords.SelectedItem as string;
            try
            {
                currentDictionary.DeleteWord(word);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка при удалении слова: " + ex.Message);
            }
            finally
            {
                RefreshWordList();
                listBoxTranslations.Items.Clear();
                panelButtons.Visible = false;
            }


        }

        private void removeTranslation(object sender , EventArgs e)
        {
            try
            {
                if (listBoxTranslations.SelectedItem is string translation && listBoxWords.SelectedItem is string word && currentDictionary != null)
                {
                    currentDictionary.DeleteTranslation(word , translation);
                    RefreshTranslations();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка при удалении перевода: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Ошибка при удалении перевода: " + ex.Message);
            }
        }
        private void saveToFile_Click(object sender , EventArgs e)
        {
            if (currentDictionary == null)
            {
                MessageBox.Show("Нет загруженного словаря.");
                return;
            }
            if (saveToFile.Tag is string selectedWord)
            {
                try
                {
                    using var sfd = new SaveFileDialog();
                    sfd.Filter = "JSON файлы (*.json)|*.json";
                    sfd.InitialDirectory = wordsExportFolder;
                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;
                    DictionaryStorage.ExportWordToFile(
                        currentDictionary ,
                        selectedWord ,
                        Path.GetFileName(sfd.FileName) ,
                        Path.GetDirectoryName(sfd.FileName) ?? wordsExportFolder
                    );
                    MessageBox.Show("Экспортировано!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при экспорте: " + ex.Message);
                }
            }

        }

        private void createNewFileToolStripMenuItem_Click(object sender , EventArgs e)
        {
            try
            {
                string? dictName = Prompt.ShowDialog("Введите название словаря:" , "Создать новый словарь");
                if (string.IsNullOrWhiteSpace(dictName)) return;
                currentDictionary = new LanguageDictionary(dictName);
                currentFilePath = Path.Combine(dictionariesFolder , dictName + ".json");
                currentDictionary.Save(Path.GetFileName(currentFilePath) , dictionariesFolder);
                RefreshWordList();
                panelButtons.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании словаря: " + ex.Message);
            }
        }
    }
}
