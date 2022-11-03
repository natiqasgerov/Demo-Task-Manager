using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TaskManagerDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.ProcessesName.Contains(name_textblock.Text))
            {
                Joke(name_textblock.Text);
                MainWindow.PName = null;
            }
            else
                MainWindow.PName = name_textblock.Text;

            this.Close();
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Joke(string text)
        {
            var pc = Process.Start(text);
            Thread.Sleep(1000);
            pc.Kill();
        }
    }
}
