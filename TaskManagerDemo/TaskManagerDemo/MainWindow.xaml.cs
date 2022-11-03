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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TaskManagerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<MyProcess> MyProcesses { get; set; } = new();

        public static List<string> ProcessesName = new();
        public int Temp { get; set; }
        public static string PName { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1.3);
            dispatcherTimer.Tick += MyMethod;
            dispatcherTimer.Start();



            foreach (var item in Process.GetProcesses())
            {
                MyProcesses.Add(new MyProcess()
                {
                    Id = item.Id,
                    Name = item.ProcessName,
                    HandleCount = item.HandleCount,
                    ThreadCount = item.Threads.Count
                });
            }

            
            process_datagrid.IsReadOnly = true;
            DataContext = this;
            Thread thread = new(Refresh);
            thread.Start();

        }
        public void Refresh()
        {
            while (true)
            {
                
                int sum = 0;

                MyProcesses.Clear();
                
                foreach (var item in Process.GetProcesses())
                {
                    MyProcesses.Add(new MyProcess()
                    {
                        Id = item.Id,
                        Name = item.ProcessName,
                        HandleCount = item.HandleCount,
                        ThreadCount = item.Threads.Count
                    });
                    sum += item.Threads.Count;
                }
                               
                this.Dispatcher.Invoke(() => {
                    process_datagrid.Items.Refresh();
                    count_textblock.Text = sum.ToString();
                });
                
                Thread.Sleep(900);
            }
        }
        
        private void process_datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(process_datagrid.SelectedItem != null)
                Temp = Convert.ToInt32(process_datagrid.SelectedItem.ToString());
        }

        private void end_btn_Click(object sender, RoutedEventArgs e)
        {   
            if(Temp!=0)
            {
                var pc = Process.GetProcessById(Temp);
                pc.Kill();
            }    
            
        }

        private void run_btn_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
            if(PName!=null)
                Process.Start(PName);
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Temp!=0)
            {
                var pc = Process.GetProcessById(Temp);
                ProcessesName.Add(pc.ProcessName);
            }
        }

        private void MyMethod(object sender,EventArgs e)
        {
            if (ProcessesName.Count != 0)
            {
                foreach (var item in ProcessesName)
                {
                    var pc = Process.GetProcessesByName(item).ToList();
                    pc.ForEach((x)=> x.Kill());
                }
            }
        }

    }
}
