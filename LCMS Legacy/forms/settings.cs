namespace LCMS_Legacy.forms
{
    public partial class settings : Form
    {
        ConfigManager configManager = new ConfigManager("config.xml");

        public string gamePath = ""; // задаем стандартное значение для gamePath
        public string profilesPath = ""; // задаем стандартное значение для profilesPath
        public bool closeOnGameStart2 = false; // задаем стандартное значение для profilesPath

        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            if (File.Exists("config.xml"))
            {
                Config config = configManager.LoadConfig();

                gamePath = config.GamePath;
                profilesPath = config.ProfilesFolderPath;
                closeOnGameStart2 = config.CloseOnGameStart;
            }
            else
            {
                configManager.SetDefaults("config.xml");
            }

            closeOnGameStart.Checked = closeOnGameStart2;
            gamePathTextBox.Text = gamePath;
            profilesPathTextBox.Text = profilesPath;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WORK");
            Config config = configManager.LoadConfig(); // открываем (загружаем) конфиг

            config.GamePath = gamePathTextBox.Text; // сохраняем путь к игре
            config.ProfilesFolderPath = profilesPathTextBox.Text; // сохраняем путь к папке с профилями
            config.CloseOnGameStart = closeOnGameStart.Checked; // 

            // config.ExampleSetting = "testValue"; // тестовая настройка, нужно добавить ее в classes/ConfigManager.cs по примеру

            configManager.SaveConfig(config); // сохраняем конфиг
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // открываем новое окно выбора файла
            {
                openFileDialog.Filter = "|Lethal Company.exe"; // типы файлов для открытия (шаблон)
                openFileDialog.Title = "Выберите файл Lethal Company.exe"; // заголовок открываемого окна

                if (openFileDialog.ShowDialog() == DialogResult.OK) // если мы подтвердили выбор в окне, то...
                {
                    gamePath = openFileDialog.FileName; // сохраняем путь к игре в локальную переменную
                }
            }

            gamePathTextBox.Text = gamePath;
        }

        private void profilesButton_Click(object sender, EventArgs e)
        {
            string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // получаем путь к папке Roaming

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog(); // открываем новое диалоговое окно с выбором директории
            folderBrowserDialog.SelectedPath = RoamingPath; // при старте открываем папку Roaming
            folderBrowserDialog.Description = "Выберите папку для сохранения файла"; // Задаем описание окна
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath)) // если выбрали директорию и она не ровна null
            {
                profilesPath = folderBrowserDialog.SelectedPath; // присваеваем локальной переменной профилей значение выбранной папки
            }

            profilesPathTextBox.Text = profilesPath;
        }
    }
}
