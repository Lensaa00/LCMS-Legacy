using LCMS_Legacy.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Создаем экземпляр ConfigSaver
            ConfigManager configSaver = new ConfigManager("config.xml");

            // Загружаем конфигурацию
            Config config = configSaver.LoadConfig();

            // Делаем изменения в конфигурации
            config.GamePath = "новый_путь_к_игре";
            config.ProfilesFolderPath = "новый_путь_к_папке_с_профилями";
            // Добавляем другие изменения

            // Сохраняем измененную конфигурацию
            configSaver.SaveConfig(config);

        }
    }
}
