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
using System.Windows.Media.Animation;
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

            SecApp.MouseEnter += (s, e) =>
            {
                SecApp.Background = Brushes.Gray;
            };

            SecApp.MouseLeave += (s, e) =>
            {
                SecApp.Background = Brushes.Transparent;
            };

            wnwMainWindow.MouseLeftButtonDown += (s, e) =>
            {
                DragMove();
            };

            btnExit.Click += (s, e) =>
            {
                this.Close();
            };

            btnCollapse.Click += (s, e) =>
            {
                this.WindowState = WindowState.Minimized;
            };

            btnMaximize.Click += (s, e) =>
            {
                if (this.WindowState == WindowState.Maximized)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Maximized;
            };

            #endregion


        }
    }
}
