namespace LCMS_Legacy.forms
{
    public partial class settings : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

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
            string path = RoamingPath;

            if (Directory.Exists($"{RoamingPath}/Thunderstore Mod Manager/DataFolder/LethalCompany/profiles"))
            {
                path = $"{RoamingPath}/Thunderstore Mod Manager/DataFolder/LethalCompany/profiles";
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog(); // открываем новое диалоговое окно с выбором директории
            folderBrowserDialog.SelectedPath = path; // при старте открываем папку Roaming
            folderBrowserDialog.Description = "Выберите папку для сохранения файла"; // Задаем описание окна
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath)) // если выбрали директорию и она не ровна null
            {
                profilesPath = folderBrowserDialog.SelectedPath; // присваеваем локальной переменной профилей значение выбранной папки
            }

            profilesPathTextBox.Text = profilesPath; // устанавливаем в поле ввода путь к профилям
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Сохраняем текущую позицию мыши при нажатии
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                // Получаем новую позицию окна относительно начальной точки
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);

                // Перемещаем окно на новую позицию
                Location = mousePos;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void minimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
