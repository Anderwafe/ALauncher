using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ALauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;

            #region UI settings

            Menu.MouseDown += (s, e) =>
            {
                DragMove();
            };

            wnwMainWindow.MouseDown += (s, e) =>
            {
                DragMove();
            };

            CommandBinding cb = new();

            btnExit.Command = SystemCommands.CloseWindowCommand;
            cb.Command = SystemCommands.CloseWindowCommand;
            cb.Executed += (s, e) =>
            {
                this.Close();
            };
            btnExit.CommandBindings.Add(cb);

            cb = new();
            btnMaximize.Command = SystemCommands.MaximizeWindowCommand;
            cb.Command = SystemCommands.MaximizeWindowCommand;
            cb.Executed += (s, e) =>
            {
                if (this.WindowState == WindowState.Maximized)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Maximized;
            };
            btnMaximize.CommandBindings.Add(cb);

            cb = new();
            btnCollapse.Command = SystemCommands.MinimizeWindowCommand;
            cb.Command = SystemCommands.MinimizeWindowCommand;
            cb.Executed += (s, e) =>
            {
                this.WindowState = WindowState.Minimized;
            };
            btnCollapse.CommandBindings.Add(cb);

            #endregion


        }
    }
}
