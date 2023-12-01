using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Animation;
using Path = System.IO.Path;
using SharpCompress.Common;
using SharpCompress.Archives;
using File = System.IO.File;


namespace Hesi_Wizard
{
    public partial class _1_Click_Install : Window
    {
        string tempPath = System.IO.Path.GetTempPath();
        private bool installationInProgress = false;
        private string cmpathM;
        private string pathA;
     
        public _1_Click_Install()
        {
            InitializeComponent();

            settings.Visibility = (settings.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            Hesilogo.Visibility = (Hesilogo.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            cmpath.Visibility = (cmpath.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            browsbttn.Visibility = (browsbttn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairlbl.Visibility = (repairlbl.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairbtn.Visibility = (repairbtn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            chkP.Visibility = (chkP.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            uldimg.Visibility = (uldimg.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            lblBrnd.Visibility = (lblBrnd.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        private void ShowDarkModeMessageBox(string path1)
        {
            MessageBox HWMessageBox = new MessageBox();
            HWMessageBox.Path1 = path1;
            HWMessageBox.ShowDialog();
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //BackgroundWorker LittleFunnyThreadGuy = new BackgroundWorker();
            //LittleFunnyThreadGuy.WorkerReportsProgress = true;
            //LittleFunnyThreadGuy.DoWork += worker_DoWork;
            //worker.ProgressChanged += worker_ProgressChanged;
            //LittleFunnyThreadGuy.RunWorkerAsync();
        }
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private void ToggleCardVisibility(FrameworkElement card, double targetWidth)
        {
            double currentWidth = card.ActualWidth; // Use ActualWidth for WPF
            Duration duration = new Duration(TimeSpan.FromSeconds(0.5));

            DoubleAnimation widthAnimation = new DoubleAnimation(currentWidth, targetWidth, duration);
            QuadraticEase easingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut };
            widthAnimation.EasingFunction = easingFunction;

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(widthAnimation);
            Storyboard.SetTarget(widthAnimation, card);
            Storyboard.SetTargetProperty(widthAnimation, new PropertyPath(FrameworkElement.WidthProperty));

            storyboard.Begin();
        }
        private void TGAButt_Click(object sender, RoutedEventArgs e)
        {
            settings.Visibility = (settings.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            Hesilogo.Visibility = (Hesilogo.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            cmpath.Visibility = (cmpath.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            browsbttn.Visibility = (browsbttn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairlbl.Visibility = (repairlbl.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairbtn.Visibility = (repairbtn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            chkP.Visibility = (chkP.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            uldimg.Visibility = (uldimg.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            lblBrnd.Visibility = (lblBrnd.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;

            double targetWidth = (TGACard.Width == 138) ? 0 : 138;
            Duration duration = new Duration(TimeSpan.FromSeconds(0.5));

            DoubleAnimationUsingKeyFrames widthAnimation = new DoubleAnimationUsingKeyFrames();
            widthAnimation.Duration = duration;

            EasingDoubleKeyFrame inKeyFrame = new EasingDoubleKeyFrame(targetWidth, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25)));
            inKeyFrame.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseIn };

            EasingDoubleKeyFrame outKeyFrame = new EasingDoubleKeyFrame(targetWidth, KeyTime.FromTimeSpan(duration.TimeSpan));
            outKeyFrame.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut };

            widthAnimation.KeyFrames.Add(inKeyFrame);
            widthAnimation.KeyFrames.Add(outKeyFrame);

            TGACard.BeginAnimation(WidthProperty, widthAnimation);
            if (PCard.Width > 0)
                ToggleCardVisibility(PCard, 0);

            if (NHCard.Width > 0)
                ToggleCardVisibility(NHCard, 0);

            if (GCard.Width > 0)
                ToggleCardVisibility(GCard, 0);

            ToggleCardVisibility(TGACard, (TGACard.Width == 138) ? 0 : 138);
        }
        private void NHButt_Click(object sender, RoutedEventArgs e)
        {
            settings.Visibility = (settings.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            Hesilogo.Visibility = (Hesilogo.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            cmpath.Visibility = (cmpath.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            browsbttn.Visibility = (browsbttn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairlbl.Visibility = (repairlbl.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairbtn.Visibility = (repairbtn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            chkP.Visibility = (chkP.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            uldimg.Visibility = (uldimg.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            lblBrnd.Visibility = (lblBrnd.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;

            double targetWidth = (NHCard.Width == 138) ? 0 : 138;
            Duration duration = new Duration(TimeSpan.FromSeconds(0.5));

            DoubleAnimationUsingKeyFrames widthAnimation = new DoubleAnimationUsingKeyFrames();
            widthAnimation.Duration = duration;

            EasingDoubleKeyFrame inKeyFrame = new EasingDoubleKeyFrame(targetWidth, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25)));
            inKeyFrame.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseIn };

            EasingDoubleKeyFrame outKeyFrame = new EasingDoubleKeyFrame(targetWidth, KeyTime.FromTimeSpan(duration.TimeSpan));
            outKeyFrame.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut };

            widthAnimation.KeyFrames.Add(inKeyFrame);
            widthAnimation.KeyFrames.Add(outKeyFrame);

            NHCard.BeginAnimation(WidthProperty, widthAnimation);
            if (PCard.Width > 0)
                ToggleCardVisibility(PCard, 0);

            if (GCard.Width > 0)
                ToggleCardVisibility(GCard, 0);

            if (NHCard.Width > 0)
                ToggleCardVisibility(NHCard, 0);

            ToggleCardVisibility(TGACard, 0);

        }
        private void GoosyWoosyButt_Click(object sender, RoutedEventArgs e)
        {
            settings.Visibility = (settings.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            Hesilogo.Visibility = (Hesilogo.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            cmpath.Visibility = (cmpath.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            browsbttn.Visibility = (browsbttn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairlbl.Visibility = (repairlbl.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairbtn.Visibility = (repairbtn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            chkP.Visibility = (chkP.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            uldimg.Visibility = (uldimg.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            lblBrnd.Visibility = (lblBrnd.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;

            double targetWidth = (GCard.Width == 138) ? 0 : 138;
            Duration duration = new Duration(TimeSpan.FromSeconds(0.5));

            DoubleAnimationUsingKeyFrames widthAnimation = new DoubleAnimationUsingKeyFrames();
            widthAnimation.Duration = duration;

            EasingDoubleKeyFrame inKeyFrame = new EasingDoubleKeyFrame(targetWidth, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25)));
            inKeyFrame.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseIn };

            EasingDoubleKeyFrame outKeyFrame = new EasingDoubleKeyFrame(targetWidth, KeyTime.FromTimeSpan(duration.TimeSpan));
            outKeyFrame.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut };

            widthAnimation.KeyFrames.Add(inKeyFrame);
            widthAnimation.KeyFrames.Add(outKeyFrame);

            GCard.BeginAnimation(WidthProperty, widthAnimation);
            if (PCard.Width > 0)
                ToggleCardVisibility(PCard, 0);

            if (GCard.Width > 0)
                ToggleCardVisibility(GCard, 0);

            if (NHCard.Width > 0)
                ToggleCardVisibility(NHCard, 0);

            ToggleCardVisibility(TGACard, 0); // Close TGA card
        }
        private void AEOButt_Click(object sender, RoutedEventArgs e)
        {
            settings.Visibility = (settings.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            Hesilogo.Visibility = (Hesilogo.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            cmpath.Visibility = (cmpath.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            browsbttn.Visibility = (browsbttn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairlbl.Visibility = (repairlbl.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            repairbtn.Visibility = (repairbtn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            chkP.Visibility = (chkP.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            uldimg.Visibility = (uldimg.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;
            lblBrnd.Visibility = (lblBrnd.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Hidden;

            double targetWidth = (PCard.Width == 138) ? 0 : 138;
            Duration duration = new Duration(TimeSpan.FromSeconds(0.5));

            DoubleAnimationUsingKeyFrames widthAnimation = new DoubleAnimationUsingKeyFrames();
            widthAnimation.Duration = duration;

            EasingDoubleKeyFrame inKeyFrame = new EasingDoubleKeyFrame(targetWidth, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25)));
            inKeyFrame.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseIn };

            EasingDoubleKeyFrame outKeyFrame = new EasingDoubleKeyFrame(targetWidth, KeyTime.FromTimeSpan(duration.TimeSpan));
            outKeyFrame.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut };

            widthAnimation.KeyFrames.Add(inKeyFrame);
            widthAnimation.KeyFrames.Add(outKeyFrame);

            PCard.BeginAnimation(WidthProperty, widthAnimation);
            if (PCard.Width > 0)
                ToggleCardVisibility(PCard, 0);

            if (GCard.Width > 0)
                ToggleCardVisibility(GCard, 0);

            if (NHCard.Width > 0)
                ToggleCardVisibility(NHCard, 0);

            if (TGACard.Width > 0)
                ToggleCardVisibility(TGACard, 0);
        }



        private void Close(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);        
            Process.GetCurrentProcess().Kill();
        }

        public bool IsFileFound(string fileName)
        {
            List<string> commonDirectories = new List<string>
            {
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86),
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    commonDirectories.Add(drive.RootDirectory.FullName);
                }
            }

            foreach (var directory in commonDirectories)
            {
                if (Directory.Exists(directory))
                {
                    try
                    {                     
                        if (Directory.GetFiles(directory, fileName, SearchOption.TopDirectoryOnly).Any())
                            return true;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        
                    }
                }
            }
            return false;
        }
        private async void NoHesi(object sender, RoutedEventArgs e) //actually PushinP
        {
         

            if (cmpathM == null || !System.IO.File.Exists(cmpathM))
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string desktopFilePath = System.IO.Path.Combine(desktopPath, "Content Manager.exe");
                bool isContentManagerOnDesktop = System.IO.File.Exists(desktopFilePath);

                if (!isContentManagerOnDesktop)
                {
                    System.Windows.MessageBox.Show("Content Manager not found on the desktop or invalid path!");
                    return;
                }

                cmpathM = desktopFilePath;

                SetContentManagerPath(desktopFilePath);
            }
            string[] urls = {
            "https://hwiz.b-cdn.net/PushinP/content%20ai.rar",
            "https://hwiz.b-cdn.net/PushinP/low%20spec.rar",
            "https://hwiz.b-cdn.net/PushinP/noob%20friendly.rar"
            };

            foreach (string url in urls)
            {
                Process.Start(new ProcessStartInfo { FileName = "acmanager://install?url=" + url, UseShellExecute = true });
                await Task.Delay(2800);
            }
        }

        private void CMInstall(object sender, RoutedEventArgs e)
        {
            bool isInstalled = IsFileFound("Content Manager.exe");


            if (cmpathM != null)
            {
                System.Windows.MessageBox.Show("Content Manager path set in the settings");
                return;

            }
            else
            {
                string downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Content Manager.exe";
                if (!File.Exists(downloadPath))
                {
                    BackgroundWorker Baphomet = new BackgroundWorker();
                    Baphomet.DoWork += Baphomet_DoWork;
                    Baphomet.RunWorkerAsync(downloadPath);
                }
                else
                {

                    MessageBox win2 = new MessageBox();
                    win2.Show();
                }
              
            }
        }

        private void Baphomet_DoWork(object sender, DoWorkEventArgs e)
        {
            string downloadPath = Path.GetTempPath() + "latest.rar"; 
            string extractPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (WebClient BeepBoop = new WebClient())
            {
                BeepBoop.DownloadFile(Vars.ContentMangr, downloadPath);
            }
            using (var archive = ArchiveFactory.Open(downloadPath))
            {
                foreach (var entry in archive.Entries)
                {
                    if (!entry.IsDirectory && entry.Key.EndsWith("Content Manager.exe", StringComparison.OrdinalIgnoreCase))
                    {
                        entry.WriteToDirectory(extractPath, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                        break;
                    }
                }
            }
            File.Delete(downloadPath);

            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                MB2 CMAI = new MB2();
                CMAI.Show();
            });
        }
        private async void Soul(object sender, RoutedEventArgs e)
        {
            if (installationInProgress)
            {
                return;
            }
            Sol_Install.IsEnabled = false; 
            ProgressBar.Value = 0; 
            ProgressBar.Visibility = Visibility.Visible;
            installationInProgress = true;
            string solFileName = "assettocorsa";

            string[] additionalPaths = {
            @"SteamLibrary\steamapps\common\assettocorsa\",
            @"Program Files (x86)\Steam\SteamApps\common\assettocorsa",
            @"Steam\SteamApps\common\assettocorsa"
            };

            var progress = new Progress<int>(value =>
            {
                ProgressBar.Value = value;
            });

            string assettoCorsaDirectory = await Task.Run(() => FindAssettoCorsaFolderAsync(solFileName, additionalPaths, progress));
            ProgressBar.Visibility = Visibility.Visible;
            installationInProgress = true;

            if (string.IsNullOrEmpty(assettoCorsaDirectory))
            {
                System.Windows.MessageBox.Show("Assetto Corsa folder not found on any drive. Make sure Assetto Corsa is installed.", "Hesi Wizard", MessageBoxButton.OK, MessageBoxImage.Error);
                Sol_Install.IsEnabled = true;
                installationInProgress = false;
                ProgressBar.Visibility = Visibility.Hidden;
                return;
            }

            string solConfigFolder = FindSolConfigFolder(assettoCorsaDirectory);
            if (!string.IsNullOrEmpty(solConfigFolder))
            {
                System.Windows.MessageBox.Show("Sol is already installed.", "Hesi Wizard");
                Sol_Install.IsEnabled = true;
                installationInProgress = false;
                ProgressBar.Visibility = Visibility.Hidden;
                return;
            }
            else

                using (var httpClient = new HttpClient())
                {
                    string startPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string zipPath = Path.Combine(startPath, "Sol.rar");
                    string cum = "Sol.rar";
                    string destination = assettoCorsaDirectory;
                    httpClient.Timeout = TimeSpan.FromSeconds(123);
                    httpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("Mozilla", "5.0"));
                    httpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("AppleWebKit", "537.36"));
                    httpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("Chrome", "58.0.3029.110"));
                    httpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("Safari", "537.3"));
                    
                    ProgressBar.Value = 0;

                    HttpResponseMessage response = await httpClient.GetAsync(Vars.Soul); 
                    response.EnsureSuccessStatusCode();
                    httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("gzip"));
                    long totalDownloadSize = response.Content.Headers.ContentLength ?? -1;

                    using (var memoryStream = new MemoryStream())
                    {
                        using (var downloadStream = await response.Content.ReadAsStreamAsync())
                        {
                            var buffer = new byte[8192];
                            int bytesRead;
                            long totalBytesRead = 0;

                            while ((bytesRead = await downloadStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                            {
                                await memoryStream.WriteAsync(buffer, 0, bytesRead);
                                totalBytesRead += bytesRead;

                                if (totalDownloadSize > 0)
                                {
                                    int progressPercentage = (int)((totalBytesRead / (double)totalDownloadSize) * 100);
                                    ProgressBar.Value = progressPercentage;
                                }
                            }
                        }

                        using (var fileStream = new FileStream(zipPath, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            memoryStream.Seek(0, SeekOrigin.Begin);
                            await memoryStream.CopyToAsync(fileStream);
                        }
                    }

                    DirectoryInfo downloadDir = new DirectoryInfo(startPath);
                    FileInfo[] files = downloadDir.GetFiles(cum);
                    var filename = files[0].FullName;
                    string getFileName = Path.GetFileName(filename);
                    if (File.Exists(filename))
                    {
                        var extractionProgress = new Progress<int>(value =>
                        {
                            ProgressBar.Value = value;
                        });

                        await ExtractArchiveAsync(zipPath, destination, extractionProgress);
                    }
                    ProgressBar.Visibility = Visibility.Hidden;
                    installationInProgress = false;
                    Sol_Install.IsEnabled = true;
                    System.Windows.MessageBox.Show("Finished! :)");
                    File.Delete(filename);
                }
        }
        private async Task<string> ReadAllTextAsync(string path)
        {
            using (var reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync();
            }
        }
        private async Task<string> FindAssettoCorsaFolderAsync(string folderName, string[] additionalPaths, IProgress<int> progress)
        {
            var fixedDrives = DriveInfo.GetDrives().Where(drive => drive.DriveType == DriveType.Fixed).ToList();
            int totalDrives = fixedDrives.Count;
            int processedDrives = 0;
            var searchTasks = new List<Task<string>>();

            foreach (var drive in fixedDrives)
            {
                processedDrives++;
                int progressPercentage = (int)(processedDrives / (double)totalDrives * 100);

                string[] rootDirectories = { drive.RootDirectory.FullName };

                var task = Task.Run(() => FindFolderRecursive(rootDirectories, folderName));

                progress?.Report(progressPercentage);

                searchTasks.Add(task);
            }

            foreach (var path in additionalPaths)
            {
                var task = Task.Run(() => FindFolderRecursive(new string[] { path }, folderName));

                searchTasks.Add(task);
            }

            while (searchTasks.Count > 0)
            {
                var completedTask = await Task.WhenAny(searchTasks);
                searchTasks.Remove(completedTask);

                if (!string.IsNullOrEmpty(completedTask.Result))
                {

                    System.Windows.MessageBox.Show($"Assetto Corsa has been found!", "Hesi Wizard");
                    return completedTask.Result;
                }
            }

            Log("Assetto Corsa folder not found on any drive.");
            return null;
        }

        private void Log(string message)
        {
            Console.WriteLine(message);
        }

        private string FindSteamLibraryFolder()
        {
            var defaultSteamLibraryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Steam");
            if (Directory.Exists(defaultSteamLibraryPath))
            {
                return defaultSteamLibraryPath;
            }

            using (var key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam"))
            {
                if (key != null)
                {
                    var steamPath = key.GetValue("SteamPath") as string;
                    if (!string.IsNullOrEmpty(steamPath) && Directory.Exists(steamPath))
                    {
                        return steamPath;
                    }
                }
            }

            return null;
        }
        private string FindFolderRecursive(string[] directories, string folderName)
        {
            foreach (var directory in directories)
            {
                try
                {
                    string targetDir = Path.Combine(directory, folderName);
                    if (Directory.Exists(targetDir))
                    {
                        return targetDir;
                    }

                    string[] subDirectories = Directory.GetDirectories(directory);
                    string result = FindFolderRecursive(subDirectories, folderName);
                    if (!string.IsNullOrEmpty(result))
                        return result;
                }
                catch (UnauthorizedAccessException)
                {
                    
                }               
            }

            return null;
        }
        private string FindSolConfigFolder(string assettoCorsaDirectory)
        {
            string[] pathsToCheck = {
            @"apps\python\sol_config"
            };
           
            foreach (var path in pathsToCheck)
            {
                string fullPath = Path.Combine(assettoCorsaDirectory, path);
                if (Directory.Exists(fullPath))
                {
                    return fullPath;
                }
            }

            return null; 
        }
        private async Task ExtractArchiveAsync(string archivePath, string destination, IProgress<int> progress)
        {
            await Task.Run(() =>
            {
                using (var archive = ArchiveFactory.Open(archivePath))
                {
                    var totalFiles = archive.Entries.Count(entry => !entry.IsDirectory);
                    var extractedFiles = 0;

                    System.Windows.MessageBox.Show("Extracting... Please wait! This might take a few minutes.");

                    foreach (var entry in archive.Entries)
                    {
                        if (entry.IsDirectory)
                            continue;

                        try
                        {
                            var entryFileName = Path.Combine(destination, entry.Key);

                            Directory.CreateDirectory(Path.GetDirectoryName(entryFileName));

                            entry.WriteToFile(entryFileName, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                        }
                        catch (DirectoryNotFoundException)
                        {
                        }

                        extractedFiles++;

                        int percentage = (int)((extractedFiles / (double)totalFiles) * 100);
                        progress?.Report(percentage);
                    }
                }
            });
        }

        private string GetContentManagerPath()
        {
            string savedPath = Properties.Settings.Default.ContentManagerPath;

            if (!string.IsNullOrEmpty(savedPath) && System.IO.File.Exists(savedPath))
            {
                return savedPath;
            }

            return null;
        }
        private void SetContentManagerPath(string newPath)
        {
            Properties.Settings.Default.ContentManagerPath = newPath;
            Properties.Settings.Default.Save();
        }

        private async void TGA(object sender, RoutedEventArgs e)
        {
           

            if (cmpathM == null || !System.IO.File.Exists(cmpathM))
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string desktopFilePath = System.IO.Path.Combine(desktopPath, "Content Manager.exe");

                bool isContentManagerOnDesktop = System.IO.File.Exists(desktopFilePath);

                if (!isContentManagerOnDesktop)
                {
                    
                    System.Windows.MessageBox.Show("Content Manager not found on the desktop or invalid path!");
                    return;
                }

                cmpathM = desktopFilePath;

                SetContentManagerPath(desktopFilePath);
                System.Windows.MessageBox.Show(cmpathM);
            }

            string[] urls = {
            "https://hwiz.b-cdn.net/TGA/Traffic%20Pack.7z",
            "https://hwiz.b-cdn.net/TGA/TGA_CARS_AIO.rar"
            };

            foreach (string url in urls)
            {
                Process.Start(new ProcessStartInfo { FileName = "acmanager://install?url=" + url, UseShellExecute = true });
                await Task.Delay(2800);
            }
        }

        private async void Gthang(object sender, RoutedEventArgs e) //goosiest
        {
            if (cmpathM == null || !System.IO.File.Exists(cmpathM))
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string desktopFilePath = System.IO.Path.Combine(desktopPath, "Content Manager.exe");
                bool isContentManagerOnDesktop = System.IO.File.Exists(desktopFilePath);

                if (!isContentManagerOnDesktop)
                {
                    System.Windows.MessageBox.Show("Content Manager not found on the desktop or invalid path!");
                    return;
                }

                cmpathM = desktopFilePath;

                SetContentManagerPath(desktopFilePath);
            }

            string[] urls = {
            "https://hwiz.b-cdn.net/Goosiest/Street%20Pack.zip",
            "https://hwiz.b-cdn.net/Goosiest/Traffic%20Cars.7z"
            };

            foreach (string url in urls)
            {
                Process.Start(new ProcessStartInfo { FileName = "acmanager://install?url=" + url, UseShellExecute = true });
                await Task.Delay(2800);
            }
        }

        private async void PThang(object sender, RoutedEventArgs e) //AEO
        {
            if (cmpathM == null || !System.IO.File.Exists(cmpathM))
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string desktopFilePath = System.IO.Path.Combine(desktopPath, "Content Manager.exe");
                bool isContentManagerOnDesktop = System.IO.File.Exists(desktopFilePath);

                if (!isContentManagerOnDesktop)
                {
                    System.Windows.MessageBox.Show("Content Manager not found on the desktop or invalid path!");
                    return;
                }

                cmpathM = desktopFilePath;

                SetContentManagerPath(desktopFilePath);
            }

            string[] urls = {
            "https://hwiz.b-cdn.net/AEO/AEO%20Boyz%20-%20SRP%20Car%20Pack%20v1.5%20%28Aug%2029%202023%20Update%29.7z",
            "https://hwiz.b-cdn.net/AEO/MNBA-Mods-Traffic.rar"
            };

            foreach (string url in urls)
            {
                Process.Start(new ProcessStartInfo { FileName = "acmanager://install?url=" + url, UseShellExecute = true });
                await Task.Delay(2800);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                cmpathM = openFileDialog.FileName;
            }
            System.Windows.MessageBox.Show(cmpathM);
        }

        private void click1(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
            Process.GetCurrentProcess().Kill();
        }

        private void settings_ckick(object sender, MouseButtonEventArgs e)
        {
            settings.Visibility = (settings.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            Hesilogo.Visibility = (Hesilogo.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            cmpath.Visibility = (cmpath.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            browsbttn.Visibility = (browsbttn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            repairlbl.Visibility = (repairlbl.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            repairbtn.Visibility = (repairbtn.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            chkP.Visibility = (chkP.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            uldimg.Visibility = (uldimg.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
            lblBrnd.Visibility = (lblBrnd.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;
        }

        private async void CM_Install_Copy_Click(object sender, RoutedEventArgs e)
        {        
            if (cmpathM == null || !System.IO.File.Exists(cmpathM))
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string desktopFilePath = System.IO.Path.Combine(desktopPath, "Content Manager.exe");

                bool isContentManagerOnDesktop = System.IO.File.Exists(desktopFilePath);
                
                if (!isContentManagerOnDesktop)
                {
                    System.Windows.MessageBox.Show("Content Manager not found on the desktop or invalid path!");
                    return;  
                }

                cmpathM = desktopFilePath;

                SetContentManagerPath(desktopFilePath);
            }

            string[] urls = {
            "https://hwiz.b-cdn.net/Maps/SRP/shuto_revival_project_beta.rar",
            "https://hwiz.b-cdn.net/Maps/SRP/shuto_revival_project_beta.rar"
            };

            foreach (string url in urls)
            {
                Process.Start(new ProcessStartInfo { FileName = "acmanager://install?url=" + url, UseShellExecute = true });
                await Task.Delay(2800);
            }
        }

        private void CM_Install_Copy1_Click(object sender, RoutedEventArgs e)
        {
            string linkToOpen = "https://discord.gg/7y86taFg8a";
            Process.Start(linkToOpen);
        }

        private void repairbtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Coming next update!");
            /* string savedPathA = Properties.Settings.Default.pathA;

             using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
             {
                 folderBrowserDialog.Description = "Select Asseto root Folder";

                 DialogResult result = folderBrowserDialog.ShowDialog();

                 if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                 {
                     pathA = folderBrowserDialog.SelectedPath; 

                     Properties.Settings.Default.pathA = pathA;
                     Properties.Settings.Default.Save();

                     System.Windows.MessageBox.Show("Selected folder path: " + pathA);
                 }
                 else
                 {
                     System.Windows.MessageBox.Show("Folder selection canceled.");
                 }




                 //insert russian code here 

                 //code here to clean all cars,sol,Cm
                 //pathA is the var for the asseto corsa root dir





             }*/
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show(pathA);
        }

        private void bkrBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Coming soon!");
            
        }

        
    }
}


