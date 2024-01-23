using Octokit;
using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace LCMS_Legacy.classes
{
    internal class Updater
    {
        private const string owner = "Lensaa00";
        private const string repo = "LCMS-Legacy";
        private const string releaseTagName = "latest";

        public async Task<bool> CheckForUpdates()
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("LCMS"));
                var releases = await client.Repository.Release.GetAll(owner, repo);

                var latestRelease = releases[0]; // Первый элемент - последний релиз

                var currentVersion = Assembly.GetEntryAssembly().GetName().Version;
                var latestVersion = new Version(latestRelease.TagName);

                return latestVersion > currentVersion;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка проверки обновлений: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> PerformUpdate()
        {
            try
            {
                var client = new WebClient();
                var releases = await client.DownloadStringTaskAsync($"https://github.com/{owner}/{repo}/releases/tag/{releaseTagName}");

                var assetUrl = releases.Split('"')[5]; // Получаем URL ассета с исполняемым файлом

                var downloadPath = Path.Combine(Path.GetTempPath(), "LCMS Update.zip");

                await client.DownloadFileTaskAsync(assetUrl, downloadPath);

                // Распаковка архива и обновление файлов

                // Перезапуск приложения после обновления
                Process.Start(new ProcessStartInfo
                {
                    FileName = "LCMS Legacy.exe",
                    UseShellExecute = true
                });

                Environment.Exit(0); // Завершение текущего экземпляра приложения
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обновления: {ex.Message}");
                return false;
            }
        }
    }
}
