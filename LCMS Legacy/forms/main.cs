using LCMS_Legacy.forms;
using System.Diagnostics;

namespace LCMS_Legacy
{

    public partial class main : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        ConfigManager configManager = new ConfigManager("config.xml"); //создаем локальный объект конфига
        Updater updater = new Updater();

        public string gamePath = ""; // задаем начальное значение для gamePath
        public string profilesPath = ""; // задаем начальное значение для profilesPath
        public bool closeOnGameStart = false; // задаем стандартное значение для profilesPath

        public string selectedProfile = ""; // задаем начальное значение для selectedProfile

        public main()
        {
            InitializeComponent();
            
        }

        public void LoadConfig()
        {
            Config config = configManager.LoadConfig(); // Загружаем конфигурацию

            gamePath = config.GamePath; // загружаем директорию игры из конфига
            profilesPath = config.ProfilesFolderPath; // загружаем директорию профилей из конфига
            closeOnGameStart = config.CloseOnGameStart; // загружаем состояние флага закрытия после запуска игры
            selectedProfile = config.LastSelectedProfile; // загружаем последний выбраный конфиг

            selectedProfileText.Text = selectedProfile;
        }

        public void LoadProfiles(string folderPath)
        {
            profilesBox.Items.Clear(); // чистим все предыдущие значения

            if (Directory.Exists(folderPath)) // проверка на существование директории для загрузки профилей
            {
                string[] directories = Directory.GetDirectories(folderPath); // получаем все вло

                foreach (string directory in directories) // для каждой папки в folderPath
                {
                    string folderName = new DirectoryInfo(directory).Name; // получаем только имя папки, без пути к ней

                    profilesBox.Items.Add(folderName); // добавляем имя папки в ListBox
                }
            }
            else
            {
                Console.WriteLine("Load Profiles error"); // выводим ошибку в загрузке
            }
        }

        public void StartGame(string method)
        {
            Config config = configManager.LoadConfig(); // Загружаем конфигурацию

            gamePath = config.GamePath; // загружаем директорию игры из конфига
            profilesPath = config.ProfilesFolderPath; // загружаем директорию профилей из конфига

            if (method == "modded") // если метод запуска - modded
            {
                if (selectedProfile != "") // если выбран профиль
                {
                    string path = $"{profilesPath}/{selectedProfile}/BepInEx/core/BepInEx.Preloader.dll"; // создаем строку для запуска

                    if (File.Exists(gamePath) && File.Exists(path)) // проверяем, есть ли путь к игре, и доступна ли path
                    {
                        string arguments = $"--doorstop-enable true --doorstop-target \"{path}\""; // добавляем к запуску игры аргументы

                        ProcessStartInfo startInfo = new ProcessStartInfo(); //
                        startInfo.FileName = gamePath;                       // Запуск
                        startInfo.Arguments = arguments;                     // Запуск
                        Process.Start(startInfo);                            //
                    }
                    else
                    {
                        Console.WriteLine("Не удалось найти Lethal Company.exe"); // выводим ошибку
                    }
                }
                else
                {
                    Console.WriteLine("Не выбран профиль для запуска"); // выводим ошибку
                }
            }
            else if (method == "vanilla") // если метод запуска - vanilla
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();//
                startInfo.FileName = gamePath;                      // Запуск
                Process.Start(startInfo);                           //
            }
            else
            {
                Console.WriteLine("Выбран неверный метод"); // выводим ошибку
            }

            if (closeOnGameStart == true)
            {
                Application.Exit(); // закрытие приложения (полный выход)
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (!configManager.CheckConfig("config.xml")) // если конфига нет, то...
            {
                startup form = new startup(); // создаем объект формы с начальной настройкой
                form.ShowDialog(); // показываем форму
            }

            // после закрытия начальной настройки

            LoadConfig(); // загружаем записанную конфигурацию
            LoadProfiles(profilesPath); // обновляем список профилей в profilesBox'е
            //updater.CheckForUpdates();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            settings form = new settings(); // создаем объект формы с настройками
            form.ShowDialog(); // показываем форму
            if (form.DialogResult == DialogResult.OK) // после нажатия на кнопку сохранить
            {
                LoadConfig(); // обновляем локальный конфиг
                LoadProfiles(profilesPath); // обновляем профили
            }
        }

        private void updateProfiles_Click(object sender, EventArgs e)
        {
            LoadProfiles(profilesPath); // по кнопке вызываем функцию обновления профилей
        }

        private void profilesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedProfile = profilesBox.SelectedItems[0].ToString(); // пробуем присвоить переменной значение выбранного профиля (текст)
                selectedProfileText.Text = selectedProfile;

                Config config = configManager.LoadConfig();
                config.LastSelectedProfile = selectedProfile;
                configManager.SaveConfig(config);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // выводим ошибку в консоль
            }
        }

        private void startModded_Click(object sender, EventArgs e)
        {
            StartGame("modded"); // запуск модифицированной версии
        }

        private void startVanilla_Click(object sender, EventArgs e)
        {
            StartGame("vanilla"); // запуск ванильной версии
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
