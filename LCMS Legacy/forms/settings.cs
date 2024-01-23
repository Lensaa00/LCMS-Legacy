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
            if (File.Exists("config.xml")) // если есть конфиг, то...
            {
                Config config = configManager.LoadConfig(); // заружаем конфиг

                gamePath = config.GamePath;                     //
                profilesPath = config.ProfilesFolderPath;       //  присваиваем локальным переменным значения из конфига
                closeOnGameStart2 = config.CloseOnGameStart;    // 
            }
            else
            {
                configManager.SetDefaults("config.xml"); // устанавливаем стандартные значения
            }

            closeOnGameStart.Checked = closeOnGameStart2; // устанавливаем значение флага для checkbox'a
            gamePathTextBox.Text = gamePath; // устанавливаем путь к игре в текстовое поле
            profilesPathTextBox.Text = profilesPath; // устанавливаем путь к профилям в текс. поле
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            Config config = configManager.LoadConfig(); // открываем (загружаем) конфиг

            config.GamePath = gamePathTextBox.Text; // сохраняем путь к игре
            config.ProfilesFolderPath = profilesPathTextBox.Text; // сохраняем путь к папке с профилями
            config.CloseOnGameStart = closeOnGameStart.Checked; // 

            // config.ExampleSetting = "testValue"; // тестовая настройка, нужно добавить ее в classes/ConfigManager.cs по примеру

            configManager.SaveConfig(config); // сохраняем конфиг

            MessageBox.Show("Конфигурация сохранена"); // выводим сообщение
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

            gamePathTextBox.Text = gamePath; // устанавливаем новое значение пути к игре в текстовое поле
        }

        private void profilesButton_Click(object sender, EventArgs e)
        {
            string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // получаем путь к папке Roaming

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog(); // открываем новое диалоговое окно с выбором директории
            if (profilesPathTextBox.Text != "")
            {
                folderBrowserDialog.SelectedPath = profilesPathTextBox.Text; // при старте открываем папку Roaming
            }
            else
            {
                folderBrowserDialog.SelectedPath = RoamingPath; // при старте открываем папку Roaming
            }
            folderBrowserDialog.Description = "Выберите папку для сохранения файла"; // Задаем описание окна
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath)) // если выбрали директорию и она не ровна null
            {
                profilesPath = folderBrowserDialog.SelectedPath; // присваеваем локальной переменной профилей значение выбранной папки
            }

            profilesPathTextBox.Text = profilesPath; // устанавливаем новое значение пути к профилям в текстовое поле
        }
    }
}
