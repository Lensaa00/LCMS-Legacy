﻿using System.Xml.Serialization;

public class Config
{
    public string GamePath { get; set; }
    public string ProfilesFolderPath { get; set; }

    // public bool ExampleSetting { get; set; } -- добавление новой настройки так делаем

    public Config()
    {
    }
}

public class ConfigManager
{
    private readonly string configFilePath;

    public ConfigManager(string configFilePath)
    {
        this.configFilePath = configFilePath;
    }

    public void SaveConfig(Config config)
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Config));

            using (TextWriter writer = new StreamWriter(configFilePath))
            {
                serializer.Serialize(writer, config);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сохранении конфигурации: {ex.Message}");
        }
    }

    public Config LoadConfig()
    {
        Config config = null;

        try
        {
            if (File.Exists(configFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));

                using (TextReader reader = new StreamReader(configFilePath))
                {
                    config = (Config)serializer.Deserialize(reader);
                }
            }
            else
            {
                // Создаем новый экземпляр конфигурации, если файл не существует
                config = new Config();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при загрузке конфигурации: {ex.Message}");
        }

        return config;
    }

    public bool CheckConfig(string fileName)
    {
        if (File.Exists(fileName))
        {
            return true;
        }
        else { return false; }
    }
}
