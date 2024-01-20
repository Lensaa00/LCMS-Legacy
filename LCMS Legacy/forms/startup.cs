namespace LCMS_Legacy.forms
{
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

        private void startup_Load(object sender, EventArgs e)
        {
            ConfigManager configSaver = new ConfigManager("config.xml"); //создаем локальный объект конфига
            Config config = configSaver.LoadConfig(); // открываем (загружаем) конфиг

            config.GamePath = ""; // сохраняем путь к игре
            config.ProfilesFolderPath = ""; // сохраняем путь к папке с профилями
            
            // config.ExampleSetting = "testValue"; -- тестовая настройка, нужно добавить ее в classes/ConfigManager.cs
            
            configSaver.SaveConfig(config);
        }
    }
}
