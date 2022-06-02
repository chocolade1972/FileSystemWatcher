using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Watcher_WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Watcher watcher;

        public MainWindow()
        {
            InitializeComponent();

            CenterWindowOnScreen();

            var nf = new NFilters()
            {
                Size = true,
                FileName = true,
                DirectoryName = true,
            };

            watcher = new Watcher(nf);
            watcher.Created += Watcher_Changes;
            watcher.Changed += Watcher_Changes;
            watcher.Deleted += Watcher_Changes;
            watcher.Renamed += Watcher_Renamed;

            PrintMsg(Application.ResourceAssembly.ToString());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (watcher.IsStarted)
            {
                e.Cancel = MessageBox.Show("Watcher is working, are you sure to close?", "Oh!",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl
            if (e.KeyboardDevice.IsKeyDown(Key.LeftCtrl) || e.KeyboardDevice.IsKeyDown(Key.RightCtrl))
            {
                if (e.KeyboardDevice.IsKeyDown(Key.S))
                {
                    //Ctrl+S
                    SaveLogs(null, null);
                }
                else if (e.KeyboardDevice.IsKeyDown(Key.D))
                {
                    //Ctrl+D
                    ClearLogs(null, null);
                }
            }
        }

        private void Button_doit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!watcher.IsStarted)
                {
                    SetPath(textBox_path.Text.Trim());
                }

                watcher.IsStarted = !watcher.IsStarted;

                if(button_doit.Content.ToString() == "Stop")
                {
                    add_path.IsEnabled = true;
                }
                else
                {
                    add_path.IsEnabled = false;

                    RandomFiles.GenerateFiles();
                }

                button_doit.Content    = watcher.IsStarted ? "Stop" : "Start";
                button_doit.Foreground = watcher.IsStarted ? Brushes.Red : Brushes.Black;
                textBox_path.IsEnabled = !watcher.IsStarted;

                PrintMsg(watcher.IsStarted ? "watcher started...At " + DateTime.Now.ToString() : "watcher stopped...At " + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                PrintErr(ex);
            }
        }

        private void Button_options_Click(object sender, RoutedEventArgs e)
        {
            options.IsOpen = true;
        }

        private void OptionsMenu_Opened(object sender, RoutedEventArgs e)
        {
            allow_edit.IsChecked = !richTextBox_main.IsReadOnly;
            topmost_switcher.IsChecked = Topmost;

            filter_setter.IsEnabled  = !watcher.IsStarted;
            include_subdir.IsEnabled = !watcher.IsStarted;
            include_subdir.IsChecked = watcher.IncludeSubdirectories;
        }

        private void AddPath(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document"; // Default file name
            dialog.DefaultExt = ".*"; // Default file extension
            dialog.Filter = "All files|*.*"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                textBox_path.Text = dialog.FileName;
            }
        }

        private void SaveLogs(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "TXT|*.txt",
                    FileName = $"watcher_{DateTime.Now:yyyyMMddHHmmss}"
                };
                if (sfd.ShowDialog() == true)
                {
                    string path = sfd.FileName;
                    string content = new TextRange(
                    richTextBox_main.Document.ContentStart,
                    richTextBox_main.Document.ContentEnd).Text;

                    File.WriteAllText(path, content);
                    PrintMsg($"saved log to \"{path}\"");
                }
            }
            catch (Exception ex)
            {
                PrintErr(ex);
            }
        }

        private void ClearLogs(object sender, RoutedEventArgs e)
        {
            richTextBox_main.Document.Blocks.Clear();
        }

        private void Switch_Window_Topmost(object sender, RoutedEventArgs e)
        {
            Topmost = !Topmost;
        }

        private void Allow_edit_Click(object sender, RoutedEventArgs e)
        {
            richTextBox_main.IsReadOnly = !richTextBox_main.IsReadOnly;
        }

        private void Filter_setter_Click(object sender, RoutedEventArgs e)
        {
            var tmp = new FilterWindow(watcher.NFilters, watcher.Filter) { Owner = this }.ShowDialog();

            if (tmp is Fdr fdr)
            {
                watcher.Filter = fdr.Filter;
                watcher.NFilters = fdr.Nfilters;

                PrintMsg($"set Filter: Size={watcher.NFilters.Size}, FileName={watcher.NFilters.FileName}, " +
                    $"DirectoryName={watcher.NFilters.DirectoryName}, Filter=\"{watcher.Filter}\"");
            }
        }

        private void Include_subdir_Click(object sender, RoutedEventArgs e)
        {
            watcher.IncludeSubdirectories = !watcher.IncludeSubdirectories;
            PrintMsg($"IncludeSubdirectories={watcher.IncludeSubdirectories}");
        }

        private void View_source_code_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/Mzying2001/Watcher_WPF");
        }

        private void TextBox_path_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Button_doit_Click(null, null);
        }

        private void RichTextBox_main_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (richTextBox_main.IsReadOnly)
                richTextBox_main.ScrollToEnd();
        }

        private void SetPath(string path)
        {
            watcher.Path = path;
            PrintMsg($"set path: \"{watcher.Path}\"");
        }

        private void Watcher_Changes(object sender, FileSystemEventArgs e)
        {
            try
            {
                if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Deleted)
                {
                    string output = $"[*] {e.ChangeType}: \"{e.FullPath}\"";
                    Println(output);
                }
                else
                {
                    var info = new FileInfo(e.FullPath);
                    var newSize = info.Length;

                    string FileN1 = "File Name : ";
                    string FileN2 = info.Name;
                    string FileN3 = " Size Has Changed : To ";
                    string FileN4 = newSize.ToString();

                    Println(FileN1 + FileN2 + FileN3 + FileN4);
                }
            }
            catch (Exception ex)
            {
                PrintErr(ex);
            }
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            try
            {
                Println($"[*] {e.ChangeType}: \"{e.OldFullPath}\" -> \"{e.FullPath}\"");
            }
            catch (Exception ex)
            {
                PrintErr(ex);
            }
        }

        private void Println(string text, SolidColorBrush brush) => Dispatcher.Invoke(() =>
        {
            richTextBox_main.Document.Blocks.Add(new Paragraph(new Run(text) { Foreground = brush }));
        });

        private void Println(string text)
        {
            Println("[+] " + text + " At : " + DateTime.Now.ToString(), Brushes.LawnGreen);
        }

        private void PrintMsg(string message)
        {
            Println($"[+] {message}", Brushes.Yellow);
        }

        private void PrintErr(Exception e)
        {
            Println($"[-] {e}", Brushes.Red);
        }

        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private byte[] CheckSize(string filename)
        {
            using (MD5 md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return md5.ComputeHash(stream);
                }
            }
        }

        private void textBox_path_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (button_doit != null)
            {
                if (textBox_path.Text == "")
                {
                    button_doit.IsEnabled = false;
                }
                else
                {
                    button_doit.IsEnabled = true;
                }
            }
        }
    }
}


// To make in changed event to display size changes. ( already exist in Options > Filter )
// to check it there and see how to add some info text about it.
// To add more designer fields radio button to decie if to watch file or all files in directory.
// if watching file the add path will be only for files dialoge.
// if watching directory the add path will use folder dialoge.
// to think on other options way for that and on other options at all.
// logger colors and more stuff.

// When saving logs to make it automatic create the log file in a specific directory path
// to think where and the directory name and file name for each log file name saving.

// To make that the Save logs button in options contextm enu will be enabled true
// only when the watcher is not running when it's stopped.
// if watching enabled false disable the save logs.

// To create a seperated text file for the exceptions content when saving the logs.
// to put the exception file with the loged saved file in both own directory.
// the directory name will be the time and date the files have saved. to think about it.