using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace FinanMan.Wpf;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public static App App => (App)Application.Current;
    
    public MainWindow()
    {
        Resources.Add("services", App.Services);

        var commandBindings = new CommandBinding[] {
            new(SystemCommands.CloseWindowCommand, CommandBinding_Executed_Close, CommandBinding_CanExecute),
            new(SystemCommands.MaximizeWindowCommand, CommandBinding_Executed_Maximize, CommandBinding_CanExecute),
            new(SystemCommands.MinimizeWindowCommand, CommandBinding_Executed_Minimize, CommandBinding_CanExecute),
            new(SystemCommands.RestoreWindowCommand, CommandBinding_Executed_Restore, CommandBinding_CanExecute)
        };
        CommandBindings.AddRange(commandBindings);
        InitializeComponent();
    }

    #region Title Bar replaced functionality
    // Can execute
    private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = true;
    }

    // Minimize
    private void CommandBinding_Executed_Minimize(object sender, ExecutedRoutedEventArgs e)
    {
        SystemCommands.MinimizeWindow(this);
    }

    // Maximize
    private void CommandBinding_Executed_Maximize(object sender, ExecutedRoutedEventArgs e)
    {
        SystemCommands.MaximizeWindow(this);
    }

    // Restore
    private void CommandBinding_Executed_Restore(object sender, ExecutedRoutedEventArgs e)
    {
        SystemCommands.RestoreWindow(this);
    }

    // Close
    private void CommandBinding_Executed_Close(object sender, ExecutedRoutedEventArgs e)
    {
        SystemCommands.CloseWindow(this);
    }

    // Show System context menu when clicking on the Icon
    private void Image_MouseButtonDown(object sender, RoutedEventArgs e)
    {
        // Position it at 8 (max border thickness on Maximized), 30 (Title Bar Height)
        var position = PointToScreen(new Point(8, 30));
        SystemCommands.ShowSystemMenu(this, position);
    }

    protected override void OnStateChanged(EventArgs e)
    {
        base.OnStateChanged(e);

        if (WindowState == WindowState.Maximized)
        {
            MyWindowBorder.BorderThickness = new Thickness(8);
            RestoreButton.Visibility = Visibility.Visible;
            MaximizeButton.Visibility = Visibility.Collapsed;
        }
        else
        {
            MyWindowBorder.BorderThickness = new Thickness(1);
            RestoreButton.Visibility = Visibility.Collapsed;
            MaximizeButton.Visibility = Visibility.Visible;
        }
    }
    #endregion Title Bar replaced functionality
}
