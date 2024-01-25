using Microsoft.VisualBasic;
using Octokit;
using System.Net;
using System.Reflection;
using System.Diagnostics;

public class Updater
{
    string gitOwner = "Lensaa00";
    string gitName = "LCMS-Legacy";

    public async void CheckForUpdates()
    {
        var client = new GitHubClient(new ProductHeaderValue("LCMSLegacy"));

        var releases = client.Repository.Release.GetAll(gitOwner, gitName);
        var latest = (await releases)[0];

        Version currentVersion = Assembly.GetEntryAssembly().GetName().Version;
        Version latestVersion = new Version(latest.TagName);

        if (latestVersion > currentVersion)
        {
            if (MessageBox.Show($"LCMS Legacy\nТекущая версия: {currentVersion.ToString(3)}\nВерсия обновления: {latestVersion}\nОбновить?", "Доступно обновление!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UpdateApp();
            }
        }
        else
        {
            MessageBox.Show("Обновления не найдены");
        }
    }

    public async void UpdateApp()
    {
        var gitClient = new GitHubClient(new ProductHeaderValue("LCMSLegacy"));

        var releases = gitClient.Repository.Release.GetAll(gitOwner, gitName);
        var latest = (await releases)[0];
        var assets = latest.Assets;
        var downloadAsset = assets[0];

        string exename = AppDomain.CurrentDomain.FriendlyName;

        Version latestVersion = new Version(latest.TagName);

        Directory.SetCurrentDirectory(AppContext.BaseDirectory);

        using (var wc = new WebClient())
        {
            wc.DownloadFile($"https://github.com/Lensaa00/LCMS-Legacy/releases/download/{latestVersion}/LCMS.Legacy.rar", "Update.rar");
            Cmd($"taskkill /f /im \"LCMS Legacy.exe\" && timeout /t 1 && tar -xf Update.rar && del Update.rar && \"LCMS Legacy.exe\"");
        }
    }

    public void Cmd (string line)
    {
        Process.Start("cmd.exe", "/c " + line);
    }
}