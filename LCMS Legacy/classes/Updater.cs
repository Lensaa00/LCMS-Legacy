using Octokit;
using System.Net;
using System.Reflection;

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
        MessageBox.Show(currentVersion.ToString());
        MessageBox.Show(latestVersion.ToString());

        if (latestVersion > currentVersion)
        {
            if (MessageBox.Show("Доступно обновление!", "test", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UpdateApp();
            }
        }
        else
        {
            MessageBox.Show("You are up-to-date!!!");
        }

        MessageBox.Show($"The latest release is tagged at {latest.TagName} and is named {latest.Name}");
    }

    public async void UpdateApp()
    {
        var gitClient = new GitHubClient(new ProductHeaderValue("LCMSLegacy"));

        var releases = gitClient.Repository.Release.GetAll(gitOwner, gitName);
        var latest = (await releases)[0];
        var assets = latest.Assets;
        var downloadAsset = assets[0];

        MessageBox.Show($"{downloadAsset.Name}, {downloadAsset.Url}");
    }
}